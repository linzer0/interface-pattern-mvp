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

        public void SetPlayerName(string name)
        {
            _playerName = name;
            PlayerNameChanged?.Invoke();
        }
        
        public string GetPlayerName() => _playerName;

        public void SetPlayerLevel(int level)
        {
            _playerLevel = level;
            PlayerLevelChanged?.Invoke();
        }

        public int GetPlayerLevel() => _playerLevel;
    }
}