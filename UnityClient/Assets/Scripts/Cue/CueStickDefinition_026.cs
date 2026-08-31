namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #026
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_026", menuName = "CueMasters/Cue #026")]
    public class CueStickDefinition_026 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_026";
        [SerializeField] private string cueName = "Master Cue #026";
        [SerializeField] private float maxShotForce = 50.0f + (26 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
