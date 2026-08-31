namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #047
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_047", menuName = "CueMasters/Cue #047")]
    public class CueStickDefinition_047 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_047";
        [SerializeField] private string cueName = "Master Cue #047";
        [SerializeField] private float maxShotForce = 50.0f + (47 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
