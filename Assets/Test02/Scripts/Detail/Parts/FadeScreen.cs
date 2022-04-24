using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Test02.Scripts.Detail.Parts
{
    public class FadeScreen : MonoBehaviour
    {
        [SerializeField] private Color _color;
        [SerializeField] private Image image;

        private CancellationToken _token;
        
        private void Awake()
        {
            Debug.Log("FadeScreen.Awake");
            _token = this.GetCancellationTokenOnDestroy();
        }

        public async UniTask ShowAsync()
        {
            Debug.Log("FadeScreen.ShowAsync");
            gameObject.SetActive(true);
            image.color = new Color(_color.r, _color.g, _color.b, 0f);

            float alpha = 0f;
            while (alpha < 1f)
            {
                alpha += 0.01f;
                image.color = new Color(_color.r, _color.g, _color.b, alpha);
                await UniTask.DelayFrame(1, cancellationToken: _token);
            }
            
            Show();
        }

        public void Show()
        {
            Debug.Log("FadeScreen.Show");
            gameObject.SetActive(true);
            image.color = _color;
        }

        public async UniTask HideAsync()
        {
            Debug.Log("FadeScreen.HideAsync");
            gameObject.SetActive(true);
            image.color = _color;

            float alpha = 1f;
            while (alpha < 0f)
            {
                alpha -= 0.01f;
                image.color = new Color(_color.r, _color.g, _color.b, alpha);
                await UniTask.DelayFrame(1, cancellationToken: _token);
            }

            Hide();
        }
        
        public void Hide()
        {
            Debug.Log("FadeScreen.Hide");
            image.color = new Color(_color.r, _color.g, _color.b, 0f);
            gameObject.SetActive(false);
        }
    }
}