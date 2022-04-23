using System.Threading;
using Codice.Client.BaseCommands;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using Test02.Scripts.CA;
using Test02.Scripts.Domain.Interfaces;
using UnityEngine;

namespace Test02.Scripts.Domain.UseCases
{
    /// <summary>
    /// HomeからGameへの遷移管理
    /// </summary>
    public class HomeTransitUseCase : IUseCase
    {
        private readonly ICommonFadeScreenPresenter _fadeScreenPresenter;
        private readonly IHomeUIController _uiController;
        private readonly CancellationToken _token;

        public HomeTransitUseCase(
            IHomeUIController uiController,
            ICommonFadeScreenPresenter fadeScreenPresenter,
            CancellationToken token)
        {
            _uiController = uiController;
            _fadeScreenPresenter = fadeScreenPresenter;
            _token = token;
        }

        public void Dispose()
        {
        }

        public UniTask InitializeAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Begin()
        {
            _uiController.OnClickToGameAsync()
                .ForEachAwaitAsync(async _ =>
                {
                    Debug.Log("click to game");
                    await _fadeScreenPresenter.ShowAsync();
                    // await SceneManager.LoadSceneAsync("");
                }, _token);
        }
    }
}