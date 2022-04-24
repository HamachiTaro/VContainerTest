using Cysharp.Threading.Tasks;
using Test02.Scripts.Domain.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Test02.Scripts.Detail
{
    public class HomeUIController : MonoBehaviour, IHomeUIController
    {
        [SerializeField] private Button buttonGame;
        
        public async UniTask OnClickToGameAsync()
        {
            await buttonGame.OnClickAsync();
        }
    }
}