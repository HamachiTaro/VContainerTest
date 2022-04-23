using Cysharp.Threading.Tasks;

namespace VContainer.Domain.Test01.Interfaces
{
    /// <summary>
    /// UIからの入力を受け付ける
    /// </summary>
    public interface IUIController
    {
        IUniTaskAsyncEnumerable<AsyncUnit> OnClickRedButtonAsync();
        IUniTaskAsyncEnumerable<AsyncUnit> OnClickGreenButtonAsync();
        IUniTaskAsyncEnumerable<AsyncUnit> OnClickBlueButtonAsync();
    }
}