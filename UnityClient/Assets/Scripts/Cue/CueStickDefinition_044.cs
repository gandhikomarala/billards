namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #044
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_044", menuName = "CueMasters/Cue #044")]
    public class CueStickDefinition_044 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_044";
        [SerializeField] private string cueName = "Master Cue #044";
        [SerializeField] private float maxShotForce = 50.0f + (44 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
