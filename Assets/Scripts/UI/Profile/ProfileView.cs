using TMPro;
using UnityEngine;

namespace UI.Profile
{
    public class ProfileView : MonoBehaviour, IProfileView
    {
        public Canvas _canvas;
        public GameObject _root;
        public TextMeshProUGUI _playerNameLabel;
        
        public void Enable()
        {
            _root.SetActive(true);
        }

        public void Disable()
        {
            _root.SetActive(false);
        }

        public void SetName(string playerName)
        {
            _playerNameLabel.SetText(playerName);
        }
    }
}