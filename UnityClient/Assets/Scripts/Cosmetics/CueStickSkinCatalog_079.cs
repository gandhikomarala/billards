namespace CueMasters.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cue Stick Cosmetic Wrap & Tip Texture #079
    /// Controls maple gloss shaders, carbon inlays, and particle strike sparks.
    /// </summary>
    [CreateAssetMenu(fileName = "CueSkin_079", menuName = "CueMasters/Cosmetics/Cue Skin #079")]
    public class CueStickSkinCatalog_079 : ScriptableObject
    {
        [SerializeField] private string skinId = "CUE_SKIN_079";
        [SerializeField] private string skinName = "Grandmaster Dragon #079";
        [SerializeField] private Color handleColor = new Color(0.85f, 0.45f, 0.15f, 1.0f);
        [SerializeField] private int unlockCostCoins = 1500 + (79 * 30);

        public string SkinId => skinId;
        public string SkinName => skinName;
        public int UnlockCostCoins => unlockCostCoins;
    }
}
