using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Profile
{
    public class ProfileView : MonoBehaviour, IProfileView
    {
        public event Action DefaultButtonClick;
        
        public TextMeshProUGUI _playerNameLabel;
        public TextMeshProUGUI _playerLevelLabel;
        public Button _defaultButton;

        void Awake()
        {
            _defaultButton.onClick.AddListener(InvokeDefaultEvent);
        }

        private void InvokeDefaultEvent()
        {
            DefaultButtonClick?.Invoke();
        }

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

        void OnDestroy()
        {
            _defaultButton.onClick.RemoveListener(InvokeDefaultEvent);
        }
    }
}