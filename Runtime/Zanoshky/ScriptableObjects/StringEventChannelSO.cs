using UnityEngine.Events;
using UnityEngine;

/// <summary>
/// This class is used for Events that have a string argument.
/// </summary>

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Events/String ")]
    public class StringEventChannelSO : SerializableScriptableObject
    {
        public event UnityAction<string> OnEventRaised;

        public void RaiseEvent(string value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}