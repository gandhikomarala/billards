namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #228
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_228", menuName = "CueMasters/Cosmetics/Cue Skin #228")]
    public class CueStickSkinCatalog_228 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_228";
        [SerializeField] private string skinName = "Grandmaster Dragon #228";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (228 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
