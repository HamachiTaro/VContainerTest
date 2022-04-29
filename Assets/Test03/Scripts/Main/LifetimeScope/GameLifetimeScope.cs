using Test03.Scripts.Detail;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Test03.Scripts.LifetimeScope
{
    public class GameLifetimeScope : VContainer.Unity.LifetimeScope
    {
        [SerializeField] private CommonFadeScreenPresenter03 fadeScreenPresenter03;
        
        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
            
            builder.RegisterComponent<ICommonFadeScreenPresenter03>(fadeScreenPresenter03);
            
            
        }
    }
}