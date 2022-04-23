using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VContainer.Domain.Test01.Interfaces;

namespace VContainer.Detail.Test01.Controller
{
    public class UIController : MonoBehaviour, IUIController
    {
        [SerializeField] private Button redButton;
        [SerializeField] private Button greenButton;
        [SerializeField] private Button blueButton;

        public IUniTaskAsyncEnumerable<AsyncUnit> OnClickRedButtonAsync()
        {
            return redButton.OnClickAsAsyncEnumerable();
        }

        public IUniTaskAsyncEnumerable<AsyncUnit> OnClickGreenButtonAsync()
        {
            return greenButton.OnClickAsAsyncEnumerable();
        }

        public IUniTaskAsyncEnumerable<AsyncUnit> OnClickBlueButtonAsync()
        {
            return blueButton.OnClickAsAsyncEnumerable();
        }
    }
}