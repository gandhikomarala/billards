namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #054
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_054", menuName = "CueMasters/Cosmetics/Cue Skin #054")]
    public class CueStickSkinCatalog_054 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_054";
        [SerializeField] private string skinName = "Grandmaster Dragon #054";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (54 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
