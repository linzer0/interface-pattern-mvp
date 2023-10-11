using UnityEngine;

namespace Organization
{
    public class Starter : MonoBehaviour
    {
        private void Awake()
        {
            CreateProfilePresenter();
        }

        private void CreateProfilePresenter()
        {
            var profilePresenter = ServiceLocator.GetProfilePresenter();
        }
    }
}