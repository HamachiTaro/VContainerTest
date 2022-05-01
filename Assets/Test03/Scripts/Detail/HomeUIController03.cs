using Cysharp.Threading.Tasks;
using Test03.Scripts.Domain.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Test03.Scripts.Detail
{
    public class HomeUIController03 : MonoBehaviour, IHomeUIController03
    {
        [SerializeField] private Button buttonGame;

        public async UniTask OnClickToGameAsync()
        {
            await buttonGame.OnClickAsync();
        }
    }
}