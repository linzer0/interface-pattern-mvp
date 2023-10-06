namespace UI.Profile
{
    public class ProfilePresenter
    {
        private ProfileModel _profileModel;
        private IProfileView _profileView;

        public ProfilePresenter()
        {
            _profileModel = new ProfileModel();
            //TODO write logic for getting ProfileView instance 
            // _profileView = 

            //TODO some way to find _profileView
            _profileView.SetPlayerName(_profileModel.GetPlayerName());
            _profileView.SetPlayerLevel(_profileModel.GetPlayerLevel());
        }
    }
}