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
        private readonly IHomeUIController03 _uiController03;
        // private readonly CancellationToken _token;

        [Inject]
        public HomeTransitUseCase(
            IHomeUIController03 uiController03
        )
        {
            _uiController03 = uiController03;
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
            await _uiController03.OnClickToGameAsync();
        }
    }
}