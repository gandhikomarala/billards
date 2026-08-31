namespace CueMasters.Balls
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Pool Ball Physical Properties & Shader Material #118
    /// Defines ball mass, rolling inertia, and number textures (Solids 1-7, 8-Ball, Stripes 9-15, Cue).
    /// </summary>
    [CreateAssetMenu(fileName = "BallDefinition_118", menuName = "CueMasters/Ball #118")]
    public class PoolBallDefinition_118 : ScriptableObject
    {
        public enum BallGroup { CueBall, Solid, Stripe, EightBall, NineBall }

        [SerializeField] private string ballId = "BALL_118";
        [SerializeField] private int ballNumber = (118 % 16);
        [SerializeField] private BallGroup group = BallGroup.Solid;
        [SerializeField] private float massGrams = 170.0f;
        [SerializeField] private float radiusMm = 28.5f;

        public int BallNumber => ballNumber;
        public BallGroup Group => group;
        public float MassGrams => massGrams;
    }
}
