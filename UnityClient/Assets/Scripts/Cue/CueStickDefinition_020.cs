namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #020
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_020", menuName = "CueMasters/Cue #020")]
    public class CueStickDefinition_020 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_020";
        [SerializeField] private string cueName = "Master Cue #020";
        [SerializeField] private float maxShotForce = 50.0f + (20 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
