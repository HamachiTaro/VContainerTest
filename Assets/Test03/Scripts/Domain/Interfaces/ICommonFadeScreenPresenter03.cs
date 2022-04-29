using Cysharp.Threading.Tasks;

namespace Test03.Scripts.Domain.Interfaces
{
    public interface ICommonFadeScreenPresenter03
    {
        UniTask ShowAsync();
        void Show();
        UniTask HideAsync();
        void Hide();
    }
}