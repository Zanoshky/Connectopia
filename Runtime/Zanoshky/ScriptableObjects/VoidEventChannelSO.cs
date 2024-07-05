using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This class is used for Events that have no arguments (Example: Exit game event)
/// </summary>
namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Events/Void ")]
    public class VoidEventChannelSO : SerializableScriptableObject
    {
        public UnityAction OnEventRaised;

        public void RaiseEvent()
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke();
        }
    }
}