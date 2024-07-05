using UnityEngine;
using System.Collections.Generic;

namespace Zanoshky
{
    [CreateAssetMenu(menuName = "Zanoshky/GameState")]
    public class GameStateSO : ScriptableObject
    {
        [Header("Debug")]
        [SerializeField] public List<string> logEvents = new List<string>();

        [Header("Game")]
        [SerializeField] public IntVariable score = default;
        [SerializeField] public IntVariable bestScore = default;
        [SerializeField] public LongVariable time = default;
        [SerializeField] public LongVariable bestTime = default;
        [SerializeField] public IntVariable review = default;

        [Header("Settings")]
        [SerializeField] public FloatVariable settingMusic = default;
        [SerializeField] public FloatVariable settingSfx = default;
        [SerializeField] public BoolVariable settingPush = default;
        [SerializeField] public BoolVariable settingVibration = default;

        [Header("Authorization")]
        [SerializeField] public StringVariable googlePlayAuthCode = default;
        [SerializeField] public StringVariable unityAuthCode = default;
        [SerializeField] public StringVariable googleId = default;
        [SerializeField] public StringVariable unityId = default;
    }
}