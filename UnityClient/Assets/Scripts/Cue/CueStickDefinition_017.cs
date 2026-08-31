namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #017
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_017", menuName = "CueMasters/Cue #017")]
    public class CueStickDefinition_017 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_017";
        [SerializeField] private string cueName = "Master Cue #017";
        [SerializeField] private float maxShotForce = 50.0f + (17 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
