namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #118
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_118", menuName = "CueMasters/Cosmetics/Cue Skin #118")]
    public class CueStickSkinCatalog_118 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_118";
        [SerializeField] private string skinName = "Grandmaster Dragon #118";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (118 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
