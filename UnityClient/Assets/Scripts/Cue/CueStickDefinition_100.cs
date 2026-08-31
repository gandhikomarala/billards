namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #100
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_100", menuName = "CueMasters/Cue #100")]
    public class CueStickDefinition_100 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_100";
        [SerializeField] private string cueName = "Master Cue #100";
        [SerializeField] private float maxShotForce = 50.0f + (100 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
