using UnityEngine.Events;
using UnityEngine;

/// <summary>
/// This class is used for Events that have a bool argument.
/// Example: An event to toggle a UI interface
/// </summary>

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Events/Bool ")]
    public class BoolEventChannelSO : SerializableScriptableObject
    {
        public event UnityAction<bool> OnEventRaised;

        public void RaiseEvent(bool value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}