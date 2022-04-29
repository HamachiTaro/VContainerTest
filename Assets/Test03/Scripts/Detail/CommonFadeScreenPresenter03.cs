using Cysharp.Threading.Tasks;
using Test03.Scripts.Detail.Parts;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;

namespace Test03.Scripts.Detail
{
    public class CommonFadeScreenPresenter03 : MonoBehaviour, ICommonFadeScreenPresenter03
    {
        [SerializeField] private FadeScreen fadeScreen;

        public async UniTask ShowAsync()
        {
            await fadeScreen.ShowAsync();
        }

        public void Show()
        {
            fadeScreen.Show();
        }

        public async UniTask HideAsync()
        {
            await fadeScreen.HideAsync();
        }

        public void Hide()
        {
            fadeScreen.Hide();
        }
    }
}