namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #285
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_285", menuName = "CueMasters/Cosmetics/Cue Skin #285")]
    public class CueStickSkinCatalog_285 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_285";
        [SerializeField] private string skinName = "Grandmaster Dragon #285";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (285 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
