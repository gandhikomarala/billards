namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #055
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_055", menuName = "CueMasters/Cue #055")]
    public class CueStickDefinition_055 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_055";
        [SerializeField] private string cueName = "Master Cue #055";
        [SerializeField] private float maxShotForce = 50.0f + (55 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
