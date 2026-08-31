namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #297
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_297", menuName = "CueMasters/Cosmetics/Cue Skin #297")]
    public class CueStickSkinCatalog_297 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_297";
        [SerializeField] private string skinName = "Grandmaster Dragon #297";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (297 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
