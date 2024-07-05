using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// This class is used for Events that have one double argument.
/// </summary>

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Events/Double ")]
    public class DoubleEventChannelSO : SerializableScriptableObject
    {
        public UnityAction<double> OnEventRaised;

        public void RaiseEvent(double value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}