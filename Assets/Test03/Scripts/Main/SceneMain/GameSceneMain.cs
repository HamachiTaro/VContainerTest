// using System;
// using System.Collections.Generic;
// using System.Threading;
// using Cysharp.Threading.Tasks;
// using Test03.Scripts.CA;
// using Test03.Scripts.Domain.Interfaces;
// using UnityEngine;
// using VContainer;
// using VContainer.Unity;
//
// namespace Test03.Scripts.Main.SceneMain
// {
//     public class GameSceneMain: /*IInitializable, */IAsyncStartable, IDisposable
//     {
//         private readonly ICommonFadeScreenPresenter03 _fadeScreenPresenter03;
//         
//         private readonly CancellationTokenSource _cts;
//         private readonly List<IUseCase> _useCases = new List<IUseCase>();
//         
//         [Inject]
//         public GameSceneMain(
//             ICommonFadeScreenPresenter03 fadeScreenPresenter03)
//         {
//             Debug.Log("GameSceneMain");
//             _fadeScreenPresenter03 = fadeScreenPresenter03;
//             
//             _cts = new CancellationTokenSource();
//             
//             
//             // _fadeScreenPresenter.Show();
//         }
//         
//         public void Dispose()
//         {
//             Debug.Log("GameScene : Dispose");
//             _cts.Cancel();
//             _cts.Dispose();
//         }
//         
//         // public void Initialize()
//         // {
//         //     
//         // }
//
//         public async UniTask StartAsync(CancellationToken cancellation)
//         {
//             // await UniTask.Delay(1000);
//             Debug.Log("GameSceneMain : StartAsync");
//             await _fadeScreenPresenter03.HideAsync();
//         }
//         
//     }
// }