using System;
using UnityEngine;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Variables/String")]
    public class StringVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public string Current;

        [NonSerialized]
        public string DefaultValue;

        public void OnAfterDeserialize()
        {
            Current = DefaultValue;
        }

        public void OnBeforeSerialize() { }
    }
}