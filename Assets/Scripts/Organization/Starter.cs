using UnityEngine;

namespace Organization
{
    public class Starter : MonoBehaviour
    {
        private void Awake()
        {
            var presenter = ServiceLocator.GetProfilePresenter();
        }
    }
}