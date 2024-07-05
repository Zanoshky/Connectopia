using System;
using UnityEngine;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Variables/Bool")]
    public class BoolVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public bool Current;

        [NonSerialized]
        public bool DefaultValue;

        public void OnAfterDeserialize()
        {
            Current = DefaultValue;
        }

        public void OnBeforeSerialize() { }
    }
}