using Cysharp.Threading.Tasks;

namespace Test03.Scripts.Domain.Interfaces
{
    public interface IGameUIController
    {
        UniTask OnClickToHomeAsync();
    }
}