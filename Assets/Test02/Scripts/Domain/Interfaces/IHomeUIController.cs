using Cysharp.Threading.Tasks;

namespace Test02.Scripts.Domain.Interfaces
{
    public interface IHomeUIController
    {
        IUniTaskAsyncEnumerable<AsyncUnit> OnClickToGameAsync();
    }
}