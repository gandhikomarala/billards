namespace CueMasters.Balls
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Pool Ball Physical Properties & Shader Material #014
    /// Defines ball mass, rolling inertia, and number textures (Solids 1-7, 8-Ball, Stripes 9-15, Cue).
    /// </summary>
    [CreateAssetMenu(fileName = "BallDefinition_014", menuName = "CueMasters/Ball #014")]
    public class PoolBallDefinition_014 : ScriptableObject
    {
        public enum BallGroup { CueBall, Solid, Stripe, EightBall, NineBall }

        [SerializeField] private string ballId = "BALL_014";
        [SerializeField] private int ballNumber = (14 % 16);
        [SerializeField] private BallGroup group = BallGroup.Solid;
        [SerializeField] private float massGrams = 170.0f;
        [SerializeField] private float radiusMm = 28.5f;

        public int BallNumber => ballNumber;
        public BallGroup Group => group;
        public float MassGrams => massGrams;
    }
}
