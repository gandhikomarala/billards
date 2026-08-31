namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #021
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_021", menuName = "CueMasters/Cue #021")]
    public class CueStickDefinition_021 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_021";
        [SerializeField] private string cueName = "Master Cue #021";
        [SerializeField] private float maxShotForce = 50.0f + (21 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
