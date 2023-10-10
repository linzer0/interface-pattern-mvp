using System;

namespace UI.Profile
{
    public class ProfileModel
    {
        public event Action PlayerNameChanged;
        public event Action PlayerLevelChanged;
        
        private string _playerName;
        private int _playerLevel;

        public ProfileModel()
        {
            _playerName = "Linar Khilazhev";
            _playerLevel = 23;
        }
        
        public string GetPlayerName()
        {
            return _playerName;
        }

        public void SetPlayerName(string name)
        {
            _playerName = name;
            PlayerNameChanged?.Invoke();
        }

        public int PlayerLevel
        {
            get => _playerLevel;
            set
            {
                _playerLevel = value;
                PlayerLevelChanged?.Invoke();
            }
        }
    }
}