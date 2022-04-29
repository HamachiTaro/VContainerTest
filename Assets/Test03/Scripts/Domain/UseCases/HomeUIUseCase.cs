using System.Threading;
using Cysharp.Threading.Tasks;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        private readonly IHomeUIController03 _homeUIController03;

        [Inject]
        public HomeUIUseCase(
            ICommonFadeScreenPresenter03 fadeScreenPresenter,
            ICommonSceneNamePresenter03 sceneNamePresenter,
            IHomeUIController03 homeUIController03)
        {
            _fadeScreenPresenter = fadeScreenPresenter;
            _sceneNamePresenter = sceneNamePresenter;
            _homeUIController03 = homeUIController03;
        }

        public void Dispose()
        {
            Debug.Log($"Dispose : {this}");
        }
        
        public async UniTask StartAsync(CancellationToken cancellation)
        {
            _sceneNamePresenter.Show("HOME...");
            _fadeScreenPresenter.Show();
            await UniTask.Delay(2000, cancellationToken: cancellation);
            
            await _fadeScreenPresenter.HideAsync();
            await _homeUIController03.OnClickToGameAsync();
            await _fadeScreenPresenter.ShowAsync();
            await SceneManager.LoadSceneAsync("Test03/Scenes/Test_03_Game");
        }
    }
}