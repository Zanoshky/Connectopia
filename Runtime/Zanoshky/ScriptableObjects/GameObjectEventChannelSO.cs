using UnityEngine.Events;
using UnityEngine;

/// <summary>
/// This class is used for Events that have one gameobject argument.
/// Example: A game object pick up event event, where the GameObject is the object we are interacting with.
/// </summary>

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Events/GameObject ")]
    public class GameObjectEventChannelSO : SerializableScriptableObject
    {
        public UnityAction<GameObject> OnEventRaised;

        public void RaiseEvent(GameObject value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }
}