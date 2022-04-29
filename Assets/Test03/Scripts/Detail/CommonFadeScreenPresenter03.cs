using Cysharp.Threading.Tasks;
using Test03.Scripts.Detail.Parts;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;

namespace Test03.Scripts.Detail
{
    public class CommonFadeScreenPresenter03 : MonoBehaviour, ICommonFadeScreenPresenter03
    {
        [SerializeField] private FadeScreen03 fadeScreen03;

        public async UniTask ShowAsync()
        {
            await fadeScreen03.ShowAsync();
        }

        public void Show()
        {
            fadeScreen03.Show();
        }

        public async UniTask HideAsync()
        {
            await fadeScreen03.HideAsync();
        }

        public void Hide()
        {
            fadeScreen03.Hide();
        }
    }
}