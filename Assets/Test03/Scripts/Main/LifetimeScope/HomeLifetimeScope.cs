using Test03.Scripts.Detail;
using Test03.Scripts.Domain.Interfaces;
using Test03.Scripts.Main.SceneMain;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test03.Scripts.LifetimeScope
{
    public class HomeLifetimeScope : VContainer.Unity.LifetimeScope
    {
        [SerializeField] private HomeUIController _homeUIController;
        [SerializeField] private CommonFadeScreenPresenter _fadeScreenPresenter;
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            builder.RegisterComponent<IHomeUIController>(_homeUIController);
            builder.RegisterComponent<ICommonFadeScreenPresenter>(_fadeScreenPresenter);
            
            builder.RegisterEntryPoint<HomeSceneMain>();
        }
    }
}