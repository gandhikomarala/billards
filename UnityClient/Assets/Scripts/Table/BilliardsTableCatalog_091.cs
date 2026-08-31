namespace CueMasters.Table
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Billiards Table Physical Dimensions & Felt Finish #091
    /// Controls cloth rolling friction, rail cushion bounciness, and pocket drop radiuses.
    /// </summary>
    [CreateAssetMenu(fileName = "TableDefinition_091", menuName = "CueMasters/Table #091")]
    public class BilliardsTableCatalog_091 : ScriptableObject
    {
        public enum FeltColor { TournamentGreen, RoyalBlue, ObsidianSlate, RubyLuxury, CyberNeon }

        [SerializeField] private string tableId = "TABLE_091";
        [SerializeField] private string tableTitle = "Tournament Table #091";
        [SerializeField] private FeltColor felt = FeltColor.TournamentGreen;
        [SerializeField] private float clothFriction = 0.988f;
        [SerializeField] private float cushionRestitution = 0.85f;
        [SerializeField] private float pocketRadiusMeters = 0.085f;

        public string TableId => tableId;
        public float ClothFriction => clothFriction;
        public float CushionRestitution => cushionRestitution;
    }
}
