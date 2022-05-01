using Cysharp.Threading.Tasks;

namespace Test03.Scripts.Domain.Interfaces
{
    public interface IGameObjectPresenter
    {
        UniTask CreateAsync(int count);
        /// <summary>
        /// オブジェクト作成開始。完了はOnCreatedAsyncで待ち受ける。
        /// </summary>
        /// <param name="count"></param>
        void Create(int count);
        UniTask OnCreatedAsync();
    }
}