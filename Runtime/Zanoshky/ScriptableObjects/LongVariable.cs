using System;
using UnityEngine;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Variables/Long")]
    public class LongVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public long Current;

        [NonSerialized]
        public long DefaultValue;

        public void OnAfterDeserialize()
        {
            Current = DefaultValue;
        }

        public void OnBeforeSerialize() { }
    }
}