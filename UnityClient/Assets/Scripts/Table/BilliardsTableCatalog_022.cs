namespace CueMasters.Table
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Billiards Table Physical Dimensions & Felt Finish #022
    /// Controls cloth rolling friction, rail cushion bounciness, and pocket drop radiuses.
    /// </summary>
    [CreateAssetMenu(fileName = "TableDefinition_022", menuName = "CueMasters/Table #022")]
    public class BilliardsTableCatalog_022 : ScriptableObject
    {
        public enum FeltColor { TournamentGreen, RoyalBlue, ObsidianSlate, RubyLuxury, CyberNeon }

        [SerializeField] private string tableId = "TABLE_022";
        [SerializeField] private string tableTitle = "Tournament Table #022";
        [SerializeField] private FeltColor felt = FeltColor.TournamentGreen;
        [SerializeField] private float clothFriction = 0.988f;
        [SerializeField] private float cushionRestitution = 0.85f;
        [SerializeField] private float pocketRadiusMeters = 0.085f;

        public string TableId => tableId;
        public float ClothFriction => clothFriction;
        public float CushionRestitution => cushionRestitution;
    }
}
