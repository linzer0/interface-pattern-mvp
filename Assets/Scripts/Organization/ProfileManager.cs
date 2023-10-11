using UI.Profile;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

namespace Organization
{
    public class ProfileManager
    {
        private static IProfileView _profileView;
        private static ProfileModel _profileModel;
        private static ProfilePresenter _profilePresenter;
        
        public static IProfileView GetProfileView()
        {
            if (_profileView == null)
            {
                var prefab = Resources.Load<ProfileView>(nameof(ProfileView));
                _profileView = Object.Instantiate<ProfileView>(prefab, Vector3.zero, Quaternion.identity);
            }

            return _profileView;
        }

        public static ProfileModel GetProfileModel()
        {
            if (_profileModel == null)
            {
                _profileModel = new ProfileModel();
            }

            return _profileModel;
        }

        public static ProfilePresenter GetProfilePresenter()
        {
            if (_profilePresenter == null)
            {
                _profilePresenter = new ProfilePresenter();
            }

            return _profilePresenter;
        }
    }
}