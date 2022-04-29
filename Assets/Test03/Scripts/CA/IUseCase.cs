using System;
using Cysharp.Threading.Tasks;

namespace Test03.Scripts.CA
{
    public interface IUseCase : IDisposable
    {
        UniTask InitializeAsync();
        void Begin();
    }
}