using System;
using Cysharp.Threading.Tasks;

namespace Test02.Scripts.CA
{
    public interface IUseCase : IDisposable
    {
        UniTask InitializeAsync();
        void Begin();
    }
}