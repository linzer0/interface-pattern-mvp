using System;

namespace UI.Profile
{
public class ProfileModel
{
    public event Action PlayerNameChanged;
    private string _playerName;
    
    public string GetPlayerName()
    {
        return _playerName;
    }

    public void SetPlayerName(string name)
    {
        _playerName = name;
        PlayerNameChanged?.Invoke();
    }
}
}