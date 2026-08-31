namespace CueMasters.Cue
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Attributes & Power Tuning #084
    /// Controls max shot force, aim guide laser length, spin transfer efficiency, and tip hardness.
    /// </summary>
    [CreateAssetMenu(fileName = "CueDefinition_084", menuName = "CueMasters/Cue #084")]
    public class CueStickDefinition_084 : ScriptableObject
    {
        [SerializeField] private string cueId = "CUE_084";
        [SerializeField] private string cueName = "Master Cue #084";
        [SerializeField] private float maxShotForce = 50.0f + (84 * 0.1f);
        [SerializeField] private float aimGuidanceLength = 15.0f;
        [SerializeField] private float spinTransferRate = 0.88f;

        public string CueId => cueId;
        public float MaxShotForce => maxShotForce;
        public float AimGuidanceLength => aimGuidanceLength;
    }
}
