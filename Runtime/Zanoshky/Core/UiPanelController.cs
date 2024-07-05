using UnityEngine;
using Zanoshky;

namespace Zanosky
{
    public class UiPanelController : MonoBehaviour
    {
        [Header("Configuration")]
        [SerializeField] private bool initialShown = false;
        [SerializeField] private bool invert = false;

        [Header("Event Channels - Listen")]
        [SerializeField] private BoolEventChannelSO ToggleEventChannel = default;

        private void Awake()
        {
            ToggleEventChannel.OnEventRaised += Toggle;
            gameObject.SetActive(initialShown);
        }

        private void Toggle(bool show)
        {
            if (invert)
            {
                gameObject.SetActive(!show);
            }
            else
            {
                gameObject.SetActive(show);
            }
        }
    }
}
