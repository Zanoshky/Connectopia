using UnityEngine.Events;
using UnityEngine;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Events/LoadEvent ")]
    public class LoadEventChannelSO : SerializableScriptableObject
    {
        public event UnityAction<LoadEvent> OnEventRaised;

        public void RaiseEvent(LoadEvent value)
        {
            if (OnEventRaised != null)
                OnEventRaised.Invoke(value);
        }
    }

    public class LoadEvent
    {
        public string text;
        public float percent;

        public LoadEvent(string text, float percent)
        {
            this.text = text;
            this.percent = percent;
        }
    }
}