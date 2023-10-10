using TMPro;
using UnityEngine;

namespace UI.Profile
{
    public class ProfileView : MonoBehaviour, IProfileView
    {
        public TextMeshProUGUI _playerNameLabel;
        public TextMeshProUGUI _playerLevelLabel;

        public void Enable()
        {
            gameObject.SetActive(true);
        }

        public void Disable()
        {
            gameObject.SetActive(false);
        }

        public void SetPlayerName(string name)
        {
            _playerNameLabel.SetText(name);
        }

        public void SetPlayerLevel(int level)
        {
            _playerLevelLabel.SetText(level.ToString());
        }
    }
}