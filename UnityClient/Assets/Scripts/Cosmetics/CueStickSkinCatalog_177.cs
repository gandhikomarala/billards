namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #177
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_177", menuName = "CueMasters/Cosmetics/Cue Skin #177")]
    public class CueStickSkinCatalog_177 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_177";
        [SerializeField] private string skinName = "Grandmaster Dragon #177";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (177 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
