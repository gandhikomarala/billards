namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #035
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_035", menuName = "CueMasters/Cue #035")]
    public class CueStickDefinition_035 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_035";
        [SerializeField] private string cueName = "Master Cue #035";
        [SerializeField] private float maxShotForce = 50.0f + (35 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
