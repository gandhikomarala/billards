namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #072
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_072", menuName = "CueMasters/Cue #072")]
    public class CueStickDefinition_072 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_072";
        [SerializeField] private string cueName = "Master Cue #072";
        [SerializeField] private float maxShotForce = 50.0f + (72 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
