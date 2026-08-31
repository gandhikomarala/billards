namespace CueMasters.Table
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Billiards Table Physical Dimensions & Felt Finish #098
    /// Controls cloth rolling friction, rail cushion bounciness, and pocket drop radiuses.
    /// </summary>
    [CreateAssetMenu(fileName = "TableDefinition_098", menuName = "CueMasters/Table #098")]
    public class BilliardsTableCatalog_098 : ScriptableObject
    {
        public enum FeltColor { TournamentGreen, RoyalBlue, ObsidianSlate, RubyLuxury, CyberNeon }

        [SerializeField] private string tableId = "TABLE_098";
        [SerializeField] private string tableTitle = "Tournament Table #098";
        [SerializeField] private FeltColor felt = FeltColor.TournamentGreen;
        [SerializeField] private float clothFriction = 0.988f;
        [SerializeField] private float cushionRestitution = 0.85f;
        [SerializeField] private float pocketRadiusMeters = 0.085f;

        public string TableId => tableId;
        public float ClothFriction => clothFriction;
        public float CushionRestitution => cushionRestitution;
    }
}
