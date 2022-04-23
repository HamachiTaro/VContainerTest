using Cysharp.Threading.Tasks;

namespace Test02.Scripts.Domain.Interfaces
{
    public interface ICommonFadeScreenPresenter
    {
        UniTask ShowAsync();
        void Show();
        UniTask HideAsync();
        void Hide();
    }
}