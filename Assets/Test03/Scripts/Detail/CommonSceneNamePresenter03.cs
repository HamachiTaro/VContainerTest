using Test03.Scripts.Domain.Interfaces;
using TMPro;
using UnityEngine;

namespace Test03.Scripts.Detail
{
    public class CommonSceneNamePresenter03 : MonoBehaviour, ICommonSceneNamePresenter03
    {
        [SerializeField] private TextMeshProUGUI tmProSceneName;
        
        public void Show(string name)
        {
            tmProSceneName.text = name;
        }
    }
}