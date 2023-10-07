using Organization;

namespace UI.Profile
{
    public class ProfilePresenter
    {
        private ProfileModel _profileModel;
        private IProfileView _profileView;

        public ProfilePresenter()
        {
            _profileModel = new ProfileModel();
            _profileView = ServiceLocator.GetProfileView();
            _profileView.SetPlayerName(_profileModel.GetPlayerName());
            _profileView.SetPlayerLevel(_profileModel.PlayerLevel);
        }
    }
}