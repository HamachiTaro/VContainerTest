using Test03.Scripts.Detail;
using Test03.Scripts.Domain.Interfaces;
using Test03.Scripts.Domain.UseCases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test03.Scripts.LifetimeScope
{
    public class HomeLifetimeScope03 : VContainer.Unity.LifetimeScope
    {
        // [SerializeField] private HomeUIController homeUIController;
        [SerializeField] private CommonFadeScreenPresenter03 fadeScreenPresenter03;
        [SerializeField] private CommonSceneNamePresenter03 sceneNamePresenter03;
        
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            // builder.RegisterComponent<IHomeUIController>(homeUIController);
            builder.RegisterComponent<ICommonFadeScreenPresenter03>(fadeScreenPresenter03);
            builder.RegisterComponent<ICommonSceneNamePresenter03>(sceneNamePresenter03);

            // entry point...
            builder.RegisterEntryPoint<HomeUIUseCase>();
        }
    }
}