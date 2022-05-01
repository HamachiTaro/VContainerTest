using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Test03.Scripts.Detail
{
    public class GameGameObjectPresenter : MonoBehaviour, IGameObjectPresenter, IDisposable
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform container;
        private List<GameObject> _objectPool;
        private bool _isCreated;
        
        public async UniTask CreateAsync(int count)
        {
            _objectPool = new List<GameObject>(count);
            await CreateInternalAsync(count);
        }

        public void Create(int count)
        {
            _objectPool = new List<GameObject>(count);
            _isCreated = false;
            CreateInternalAsync(count).Forget();
        }

        public async UniTask OnCreatedAsync()
        {
            await UniTask.WaitUntil(() => _isCreated);
            Debug.Log("Created!!!!!!!");
        }

        private async UniTask CreateInternalAsync(int count)
        {
            // 60fps
            var timeLimitPerFrame = 1 / 60f;
            var elapsedSec = 0f;

            while (true)
            {
                var go = GameObject.Instantiate(prefab, Random.insideUnitSphere * 5f, Quaternion.identity, container);
                go.transform.localScale = Vector3.one * 0.1f;
                _objectPool.Add(go);
                if (_objectPool.Count == count)
                {
                    break;
                }

                elapsedSec += Time.deltaTime;
                if (elapsedSec > timeLimitPerFrame)
                {
                    // Debug.Log("next frame...");
                    elapsedSec = 0f;
                    await UniTask.Yield();
                }
            }

            _isCreated = true;
        }

        public void Dispose()
        {
            _objectPool.Clear();
        }
    }
}