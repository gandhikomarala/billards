namespace CueMasters.Balls
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Pool Ball Physical Properties & Shader Material #083
    /// Defines ball mass, rolling inertia, and number textures (Solids 1-7, 8-Ball, Stripes 9-15, Cue).
    /// </summary>
    [CreateAssetMenu(fileName = "BallDefinition_083", menuName = "CueMasters/Ball #083")]
    public class PoolBallDefinition_083 : ScriptableObject
    {
        public enum BallGroup { CueBall, Solid, Stripe, EightBall, NineBall }

        [SerializeField] private string ballId = "BALL_083";
        [SerializeField] private int ballNumber = (83 % 16);
        [SerializeField] private BallGroup group = BallGroup.Solid;
        [SerializeField] private float massGrams = 170.0f;
        [SerializeField] private float radiusMm = 28.5f;

        public int BallNumber => ballNumber;
        public BallGroup Group => group;
        public float MassGrams => massGrams;
    }
}
