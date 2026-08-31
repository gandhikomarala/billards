namespace CueMasters.Scoring
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Match Score & XP Progression Calculator #038
    /// Computes runouts, break-and-run bonuses, and player level progression.
    /// </summary>
    public class MatchScoreCalculator_038
    {
        public int CalculateMatchScore(int ballsPocketed, bool isBreakAndRun, int fouls)
        {
            int score = ballsPocketed * 50;
            if (isBreakAndRun) score += 250;
            score = Math.Max(0, score - (fouls * 30));
            return score;
        }
    }
}
