using System.Threading;
using Cysharp.Threading.Tasks;
using Test03.Scripts.Domain.Interfaces;
using VContainer;

namespace Test03.Scripts.Domain.UseCases
{
    /// <summary>
    /// HomeからGameへの遷移管理
    /// </summary>
    public class HomeTransitUseCase
    {
        private readonly IHomeUIController _uiController;
        // private readonly CancellationToken _token;

        [Inject]
        public HomeTransitUseCase(
            IHomeUIController uiController
        )
        {
            _uiController = uiController;
            // _token = token;
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
        }

        public async UniTask TransitSelectAsync()
        {
            await _uiController.OnClickToGameAsync();
        }
    }
}