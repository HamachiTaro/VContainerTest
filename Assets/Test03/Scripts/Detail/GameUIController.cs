using Cysharp.Threading.Tasks;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Test03.Scripts.Detail
{
    public class GameUIController : MonoBehaviour, IGameUIController
    {
        [SerializeField] private Button buttonToHome;
        
        public async UniTask OnClickToHomeAsync()
        {
            await buttonToHome.OnClickAsync();
        }
    }
}