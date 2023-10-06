using System;

namespace UI.Profile
{
    public class ProfileModel
    {
        public event Action PlayerNameChanged;
        public event Action PlayerLevelChanged;

        private string _playerName;
        private int _playerLevel;

        public string GetPlayerName()
        {
            return _playerName;
        }

        public int GetPlayerLevel()
        {
            return _playerLevel;
        }

        public void SetPlayerLevel(int value)
        {
            _playerLevel = value;
            PlayerLevelChanged?.Invoke();
        }

        public void SetPlayerName(string name)
        {
            _playerName = name;
            PlayerNameChanged?.Invoke();
        }
    }
}