using System;
using System.Threading;
using Cysharp.Threading.Tasks.Linq;
using UnityEngine;
using VContainer.Domain.Test01.Interfaces;
using VContainer.Unity;

namespace VContainer.Test01.Domain.UseCases
{
    public class SomeUseCase : IInitializable, IStartable, IDisposable
    {
        private readonly IUIController _uiController;
        private readonly ICubeColorPresenter _cubeColorPresenter;

        private readonly CancellationTokenSource _cts;
        
        [Inject] // コンストラクタインジェクション。基本的にこれを使用する。
        public SomeUseCase(
            IUIController uiController,
            ICubeColorPresenter cubeColorPresenter
        )
        {
            _uiController = uiController;
            _cubeColorPresenter = cubeColorPresenter;

            _cts = new CancellationTokenSource();
        }
        
        /// <summary>
        /// IDisposableを実装しておけばDisposeを呼んでくれる。
        /// </summary>
        public void Dispose()
        {
            Debug.Log("DISPOSE !!");
            _cts.Cancel();
            _cts.Dispose();
        }
        
        public void Initialize()
        {
            Debug.Log("*** Initialize ***");
            SetCubeColor(Color.red);
        }

        // MonoBehaviourのStartと同期するらしい。
        public void Start()
        {
            Debug.Log("*** Start ***");
            
            _uiController.OnClickRedButtonAsync()
                .ForEachAsync(_ =>
                {
                    SetCubeColor(Color.red);
                }, _cts.Token);
            
            _uiController.OnClickGreenButtonAsync()
                .ForEachAsync(_ =>
                {
                    SetCubeColor(Color.green);
                }, _cts.Token);
            
            _uiController.OnClickBlueButtonAsync()
                .ForEachAsync(_ =>
                {
                    SetCubeColor(Color.blue);
                }, _cts.Token);
        }

        private void SetCubeColor(Color color)
        {
            _cubeColorPresenter.SetCubeColor(color);
        }
    }
}