namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #036
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_036", menuName = "CueMasters/Cue #036")]
    public class CueStickDefinition_036 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_036";
        [SerializeField] private string cueName = "Master Cue #036";
        [SerializeField] private float maxShotForce = 50.0f + (36 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
