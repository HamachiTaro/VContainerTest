using Test03.Scripts.Detail;
using Test03.Scripts.Domain.Interfaces;
using Test03.Scripts.Domain.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test03.Scripts.LifetimeScope
{
    public class GameLifetimeScope03 : VContainer.Unity.LifetimeScope
    {
        [SerializeField] private CommonFadeScreenPresenter03 fadeScreenPresenter03;
        [SerializeField] private CommonSceneNamePresenter03 sceneNamePresenter03;
        [SerializeField] private GameGameObjectPresenter gameObjectPresenter;
        
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
            
            builder.RegisterComponent<ICommonFadeScreenPresenter03>(fadeScreenPresenter03);
            builder.RegisterComponent<ICommonSceneNamePresenter03>(sceneNamePresenter03);
            builder.RegisterComponent<IGameObjectPresenter>(gameObjectPresenter);
            
            // entry point...
            builder.RegisterEntryPoint<GameUIUseCase>();
            builder.RegisterEntryPoint<GameGameUseCase>();
        }
    }
}