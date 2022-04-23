using Cysharp.Threading.Tasks;
using Test02.Scripts.Detail.Parts;
using Test02.Scripts.Domain.Interfaces;
using UnityEngine;

namespace Test02.Scripts.Detail
{
    public class CommonFadeScreenPresenter : MonoBehaviour, ICommonFadeScreenPresenter
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