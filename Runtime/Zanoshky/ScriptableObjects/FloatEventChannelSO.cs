using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This class is used for Events that have one float argument.
/// </summary>

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Events/Float ")]
    public class FloatEventChannelSO : SerializableScriptableObject
    {
        public UnityAction<float> OnEventRaised;

        public void RaiseEvent(float value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}