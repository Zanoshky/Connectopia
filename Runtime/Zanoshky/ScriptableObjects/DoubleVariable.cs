using System;
using UnityEngine;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/Variables/Double")]
    public class DoubleVariable : ScriptableObject, ISerializationCallbackReceiver
    {
        public double Current;

        [NonSerialized]
        public double DefaultValue;

        public void OnAfterDeserialize()
        {
            Current = DefaultValue;
        }

        public void OnBeforeSerialize() { }
    }
}