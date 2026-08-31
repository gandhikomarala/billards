namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #050
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_050", menuName = "CueMasters/Cue #050")]
    public class CueStickDefinition_050 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_050";
        [SerializeField] private string cueName = "Master Cue #050";
        [SerializeField] private float maxShotForce = 50.0f + (50 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
