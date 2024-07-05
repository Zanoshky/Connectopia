using System;
using UnityEngine;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Variables/Float")]
    public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public float Current;

        [NonSerialized]
        public float DefaultValue;

        public void OnAfterDeserialize()
        {
            Current = DefaultValue;
        }

        public void OnBeforeSerialize() { }
    }
}