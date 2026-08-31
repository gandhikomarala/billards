namespace CueMasters.Table
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Billiards Table Physical Dimensions & Felt Finish #095
    /// Controls cloth rolling friction, rail cushion bounciness, and pocket drop radiuses.
    /// </summary>
    [CreateAssetMenu(fileName = "TableDefinition_095", menuName = "CueMasters/Table #095")]
    public class BilliardsTableCatalog_095 : ScriptableObject
    {
        public enum FeltColor { TournamentGreen, RoyalBlue, ObsidianSlate, RubyLuxury, CyberNeon }

        [SerializeField] private string tableId = "TABLE_095";
        [SerializeField] private string tableTitle = "Tournament Table #095";
        [SerializeField] private FeltColor felt = FeltColor.TournamentGreen;
        [SerializeField] private float clothFriction = 0.988f;
        [SerializeField] private float cushionRestitution = 0.85f;
        [SerializeField] private float pocketRadiusMeters = 0.085f;

        public string TableId => tableId;
        public float ClothFriction => clothFriction;
        public float CushionRestitution => cushionRestitution;
    }
}
