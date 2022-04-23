using Test02.Scripts.Detail;
using Test02.Scripts.Domain.Interfaces;
using Test02.Scripts.Main.SceneMain;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test02.Scripts.LifetimeScope
{
    public class HomeLifetimeScope : VContainer.Unity.LifetimeScope
    {
        [SerializeField] private HomeUIController _homeUIController;

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            builder.RegisterComponent<IHomeUIController>(_homeUIController);
            
            
            builder.RegisterEntryPoint<HomeSceneMain>();
        }
    }
}