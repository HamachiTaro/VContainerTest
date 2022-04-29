using Test03.Scripts.Detail;
using Test03.Scripts.Domain.Interfaces;
using Test03.Scripts.Main.SceneMain;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test03.Scripts.LifetimeScope
{
    public class GameLifetimeScope : VContainer.Unity.LifetimeScope
    {
        [SerializeField] private CommonFadeScreenPresenter _fadeScreenPresenter;
        
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
            
            builder.RegisterComponent<ICommonFadeScreenPresenter>(_fadeScreenPresenter);
            
            builder.RegisterEntryPoint<GameSceneMain>();
        }
    }
}