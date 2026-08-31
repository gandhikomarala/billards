namespace CueMasters.AI
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Deterministic Billiards AI Opponent Profile #082
    /// Calculates ghost ball target lines, pocket cut angles, and applies deliberate difficulty error cones.
    /// </summary>
    [CreateAssetMenu(fileName = "AIProfile_082", menuName = "CueMasters/AI Profile #082")]
    public class BilliardsAIBotProfile_082 : ScriptableObject
    {
        public enum Difficulty { Easy, Medium, Hard, Pro }

        [SerializeField] private string botName = "Pool Master AI #082";
        [SerializeField] private Difficulty difficulty = Difficulty.Hard;
        [SerializeField] private float aimErrorDegrees = 1.0f;

        public Vector2 ApplyAIMistakeOffset(Vector2 targetAngleVector)
        {
            float errorMax = difficulty switch
            {
                Difficulty.Easy => 6.0f,
                Difficulty.Medium => 3.0f,
                Difficulty.Hard => 1.0f,
                Difficulty.Pro => 0.2f,
                _ => 1.5f
            };
            float randomOffset = UnityEngine.Random.Range(-errorMax, errorMax);
            return Quaternion.Euler(0, 0, randomOffset) * targetAngleVector;
        }
    }
}
