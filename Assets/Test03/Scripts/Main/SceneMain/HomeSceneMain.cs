// using System;
// using System.Collections.Generic;
// using System.Threading;
// using Cysharp.Threading.Tasks;
// using Test03.Scripts.CA;
// using Test03.Scripts.Domain.Interfaces;
// using Test03.Scripts.Domain.UseCases;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using VContainer;
// using VContainer.Unity;
//
// namespace Test03.Scripts.Main.SceneMain
// {
//     public class HomeSceneMain : IInitializable, IAsyncStartable, IDisposable
//     {
//         private readonly ICommonFadeScreenPresenter03 _fadeScreenPresenter03;
//         private readonly IHomeUIController _uiController;
//
//         private readonly CancellationTokenSource _cts;
//         
//
//         private HomeTransitUseCase _transitUseCase;
//
//         [Inject]
//         public HomeSceneMain(
//             ICommonFadeScreenPresenter03 fadeScreenPresenter03,
//             IHomeUIController uiController)
//         {
//             Debug.Log("HomeSceneMain Constructor");
//
//             _fadeScreenPresenter03 = fadeScreenPresenter03;
//             _uiController = uiController;
//
//             _cts = new CancellationTokenSource();
//         }
//
//         public void Dispose()
//         {
//             Debug.Log("HomeSceneMain : Dispose");
//             _cts.Cancel();
//             _cts.Dispose();
//         }
//
//         public void Initialize()
//         {
//             Debug.Log("*** Initialize ***");
//             var token = _cts.Token;
//
//             // _transitUseCase = new HomeTransitUseCase(_uiController, token);
//             _useCases.Add(_transitUseCase);
//
//             foreach (var useCase in _useCases)
//             {
//                 useCase.Begin();
//             }
//         }
//
//         public async UniTask StartAsync(CancellationToken cancellation)
//         {
//             Debug.Log("*** StartAsync ***");
//
//             await _transitUseCase.TransitSelectAsync();
//
//             await _fadeScreenPresenter03.ShowAsync();
//
//             await SceneManager.LoadSceneAsync("Game").WithCancellation(_cts.Token);
//         }
//     }
// }