using UnityEngine;
using VContainer.Detail.Test01.Controller;
using VContainer.Detail.Test01.Presenter;
using VContainer.Test01.Domain.UseCases;
using VContainer.Unity;

namespace VContainer.Test01.Main
{
    public class MyLifetimeScope : LifetimeScope
    {
        [SerializeField] private UIController uiController;
        [SerializeField] private CubeColorPresenter cubeColorPresenter;

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);

            // アタッチされたコンポーネントからインターフェースを登録する
            builder.RegisterComponent(uiController).AsImplementedInterfaces();
            builder.RegisterComponent(cubeColorPresenter).AsImplementedInterfaces();

            // EntryPointを設定
            builder.RegisterEntryPoint<SomeUseCase>();
        }
    }
}