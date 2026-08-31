namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #091
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_091", menuName = "CueMasters/Cue #091")]
    public class CueStickDefinition_091 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_091";
        [SerializeField] private string cueName = "Master Cue #091";
        [SerializeField] private float maxShotForce = 50.0f + (91 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
