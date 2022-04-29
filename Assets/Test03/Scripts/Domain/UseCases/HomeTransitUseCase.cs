using System.Threading;
using Codice.Client.BaseCommands;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using Test03.Scripts.CA;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;

namespace Test03.Scripts.Domain.UseCases
{
    /// <summary>
    /// HomeからGameへの遷移管理
    /// </summary>
    public class HomeTransitUseCase : IUseCase
    {
        private readonly IHomeUIController _uiController;
        private readonly CancellationToken _token;

        public HomeTransitUseCase(
            IHomeUIController uiController,
            CancellationToken token)
        {
            _uiController = uiController;
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
        }

        public async UniTask TransitSelectAsync()
        {
            await _uiController.OnClickToGameAsync();
        }
    }
}