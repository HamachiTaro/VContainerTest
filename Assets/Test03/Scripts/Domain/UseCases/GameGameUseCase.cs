using System.Threading;
using Cysharp.Threading.Tasks;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test03.Scripts.Domain.UseCases
{
    public class GameGameUseCase : IAsyncStartable
    {
        private readonly IGameObjectPresenter _objectPresenter;

        [Inject]
        public GameGameUseCase(
            IGameObjectPresenter objectPresenter)
        {
            _objectPresenter = objectPresenter;
        }

        public void Dispose()
        {
            Debug.Log($"dispose : {this}");
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            await _objectPresenter.CreateAsync(3000);
            
            // todo このタイミングでui側にfadeするように通知したい message pipe?
        }
    }
}