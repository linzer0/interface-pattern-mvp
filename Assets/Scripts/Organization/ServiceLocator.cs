using UI.Profile;
using UnityEngine;

namespace Organization
{
    public static class ServiceLocator
    {
        private static IProfileView _profileView;
        
        public static IProfileView GetProfileView()
        {
            if (_profileView == null)
            {
                var prefab = Resources.Load<ProfileView>(typeof(ProfileView).ToString());
                _profileView = Object.Instantiate<ProfileView>(prefab, Vector3.zero, Quaternion.identity);
            }

            return _profileView;
        }
    }
}