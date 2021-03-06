using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using Test02.Scripts.CA;
using Test02.Scripts.Domain.Interfaces;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test02.Scripts.Main.SceneMain
{
    public class GameSceneMain: /*IInitializable, */IAsyncStartable, IDisposable
    {
        private readonly ICommonFadeScreenPresenter _fadeScreenPresenter;
        
        private readonly CancellationTokenSource _cts;
        private readonly List<IUseCase> _useCases = new List<IUseCase>();
        
        [Inject]
        public GameSceneMain(
            ICommonFadeScreenPresenter fadeScreenPresenter)
        {
            Debug.Log("GameSceneMain");
            _fadeScreenPresenter = fadeScreenPresenter;
            
            _cts = new CancellationTokenSource();
            
            
            // _fadeScreenPresenter.Show();
        }
        
        public void Dispose()
        {
            Debug.Log("GameScene : Dispose");
            _cts.Cancel();
            _cts.Dispose();
        }
        
        // public void Initialize()
        // {
        //     
        // }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            // await UniTask.Delay(1000);
            Debug.Log("GameSceneMain : StartAsync");
            await _fadeScreenPresenter.HideAsync();
        }
        
    }
}