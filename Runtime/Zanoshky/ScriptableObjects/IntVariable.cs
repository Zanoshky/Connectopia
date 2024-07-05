using System;
using UnityEngine;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Variables/Int")]
    public class IntVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public int Current;

        [NonSerialized]
        public int DefaultValue;

        public void OnAfterDeserialize()
        {
            Current = DefaultValue;
        }

        public void OnBeforeSerialize() { }
    }
}