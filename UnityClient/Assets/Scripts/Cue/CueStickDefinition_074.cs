namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #074
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_074", menuName = "CueMasters/Cue #074")]
    public class CueStickDefinition_074 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_074";
        [SerializeField] private string cueName = "Master Cue #074";
        [SerializeField] private float maxShotForce = 50.0f + (74 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
