using UnityEngine;
using VContainer.Domain.Test01.Interfaces;

namespace VContainer.Detail.Test01.Presenter
{
    public class CubeColorPresenter : MonoBehaviour, ICubeColorPresenter
    {
        [SerializeField] private GameObject cube;

        public void SetCubeColor(Color color)
        {
            cube.GetComponent<Renderer>().material.SetColor("_Color", color);
        }
    }
}