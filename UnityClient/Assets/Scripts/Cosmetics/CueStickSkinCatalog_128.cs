namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #128
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_128", menuName = "CueMasters/Cosmetics/Cue Skin #128")]
    public class CueStickSkinCatalog_128 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_128";
        [SerializeField] private string skinName = "Grandmaster Dragon #128";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (128 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
