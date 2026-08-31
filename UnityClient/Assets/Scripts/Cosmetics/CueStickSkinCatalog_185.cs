namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #185
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_185", menuName = "CueMasters/Cosmetics/Cue Skin #185")]
    public class CueStickSkinCatalog_185 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_185";
        [SerializeField] private string skinName = "Grandmaster Dragon #185";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (185 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
