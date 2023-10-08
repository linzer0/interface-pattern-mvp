using Organization;

namespace UI.Profile
{
    public class ProfilePresenter
    {
        private ProfileModel _profileModel;
        private IProfileView _profileView;

        public ProfilePresenter()
        {
            _profileModel = ServiceLocator.GetProfileModel();
            _profileView = ServiceLocator.GetProfileView();
            
            _profileModel.PlayerLevelChanged += UpdatePlayerLevel;
            _profileModel.PlayerNameChanged += UpdatePlayerName;
            
            _profileView.SetPlayerName(_profileModel.GetPlayerName());
            _profileView.SetPlayerLevel(_profileModel.PlayerLevel);
        }

        private void UpdatePlayerName()
        {
            _profileView.SetPlayerName(_profileModel.GetPlayerName());
        }

        private void UpdatePlayerLevel()
        {
            _profileView.SetPlayerLevel(_profileModel.PlayerLevel);
        }

        ~ProfilePresenter()
        {
            _profileModel.PlayerLevelChanged -= UpdatePlayerLevel;
            _profileModel.PlayerNameChanged -= UpdatePlayerName;
        }
    }
}