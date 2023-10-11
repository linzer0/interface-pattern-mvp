using Organization;

namespace UI.Profile
{
    public class ProfilePresenter
    {
        private ProfileModel _profileModel;
        private IProfileView _profileView;

        public ProfilePresenter()
        {
            _profileModel = ProfileManager.GetProfileModel();
            _profileView = ProfileManager.GetProfileView();
            
            _profileModel.PlayerLevelChanged += UpdatePlayerLevel;
            _profileModel.PlayerNameChanged += UpdatePlayerName;
            
            _profileView.SetPlayerName(_profileModel.GetPlayerName());
            _profileView.SetPlayerLevel(_profileModel.GetPlayerLevel());
        }

        private void UpdatePlayerName()
        {
            _profileView.SetPlayerName(_profileModel.GetPlayerName());
        }

        private void UpdatePlayerLevel()
        {
            _profileView.SetPlayerLevel(_profileModel.GetPlayerLevel());
        }

        ~ProfilePresenter()
        {
            _profileModel.PlayerLevelChanged -= UpdatePlayerLevel;
            _profileModel.PlayerNameChanged -= UpdatePlayerName;
        }
    }
}