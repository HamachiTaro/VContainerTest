using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using Test02.Scripts.CA;
using Test02.Scripts.Domain.Interfaces;
using Test02.Scripts.Domain.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test02.Scripts.Main.SceneMain
{
    public class HomeSceneMain : IInitializable, IAsyncStartable, IDisposable
    {
        private readonly ICommonFadeScreenPresenter _fadeScreenPresenter;
        private readonly IHomeUIController _uiController;

        private CancellationTokenSource _cts;
        private List<IUseCase> _useCases = new List<IUseCase>();

        [Inject]
        public HomeSceneMain(
            ICommonFadeScreenPresenter fadeScreenPresenter,
            IHomeUIController uiController)
        {
            Debug.Log("HomeSceneMain Constructor");

            _fadeScreenPresenter = fadeScreenPresenter;
            _uiController = uiController;

            _cts = new CancellationTokenSource();
        }

        public void Dispose()
        {
            Debug.Log("HomeSceneMain : Dispose");
            _cts.Cancel();
            _cts.Dispose();
        }

        public void Initialize()
        {
            Debug.Log("*** Initialize ***");
            var token = _cts.Token;

            var transitUseCase = new HomeTransitUseCase(
                _uiController,
                _fadeScreenPresenter,
                token);
            _useCases.Add(transitUseCase);
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            Debug.Log("*** StartAsync ***");
            await UniTask.Yield(cancellation);

            foreach (var useCase in _useCases)
            {
                useCase.Begin();
            }
        }
    }
}