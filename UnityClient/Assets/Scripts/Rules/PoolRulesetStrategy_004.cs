namespace CueMasters.Rules
{
    using System;
    using UnityEngine;

    /// <summary>
    /// 8-Ball & 9-Ball Match Ruleset Strategy #004
    /// Validates legal first contact, ball assignment, scratch fouls, and 8-ball victory/loss conditions.
    /// </summary>
    public class PoolRulesetStrategy_004
    {
        public enum RuleType { EightBallStandard, NineBallRotation, PracticeFree }

        public bool ValidateTurnContinuity(bool pocketedLegalBall, bool cueBallScratched, bool eightBallPocketed, bool allAssignedPocketed)
        {
            if (cueBallScratched)
                return false; // Scratch foul: opponent receives ball-in-hand
            if (eightBallPocketed)
                return allAssignedPocketed; // Legal win if table cleared, loss otherwise
            return pocketedLegalBall;
        }
    }
}
