namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #188
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_188", menuName = "CueMasters/Cosmetics/Cue Skin #188")]
    public class CueStickSkinCatalog_188 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_188";
        [SerializeField] private string skinName = "Grandmaster Dragon #188";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (188 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
