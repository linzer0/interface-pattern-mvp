using UnityEngine;

namespace Organization
{
    public class Starter : MonoBehaviour
    {
        private void Awake()
        {
            CreatePresenter();
        }

        private void CreatePresenter()
        {
            var presenter = ServiceLocator.GetProfilePresenter();
        }
    }
}