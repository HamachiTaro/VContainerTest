using System.Threading;
using Cysharp.Threading.Tasks;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test03.Scripts.Domain.UseCases
{
    /// <summary>
    /// HomeSceneのUI周りのUseCase
    /// </summary>
    public class HomeUIUseCase : IAsyncStartable
    {
        private readonly ICommonFadeScreenPresenter03 _fadeScreenPresenter;
        private readonly ICommonSceneNamePresenter03 _sceneNamePresenter;

        [Inject]
        public HomeUIUseCase(
            ICommonFadeScreenPresenter03 fadeScreenPresenter,
            ICommonSceneNamePresenter03 sceneNamePresenter)
        {
            _fadeScreenPresenter = fadeScreenPresenter;
            _sceneNamePresenter = sceneNamePresenter;
        }

        public void Dispose()
        {
            Debug.Log($"Dispose : {this}");
        }
        
        public async UniTask StartAsync(CancellationToken cancellation)
        {
            _sceneNamePresenter.Show("HOME...");

            _fadeScreenPresenter.Show();

            await UniTask.Delay(2000);
            
            await _fadeScreenPresenter.HideAsync();
        }
    }
}