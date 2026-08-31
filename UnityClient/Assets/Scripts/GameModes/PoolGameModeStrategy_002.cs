namespace CueMasters.GameModes
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Billiards Tournament Game Mode Strategy #002
    /// Controls 8-Ball Classic, 9-Ball Speedrun, Trick Shot Challenges, and Practice Table rules.
    /// </summary>
    public class PoolGameModeStrategy_002 : MonoBehaviour
    {
        public enum MatchMode { EightBallPro, NineBallFast, TrickShotChallenge, FreePractice }

        [Header("Mode Configuration")]
        [SerializeField] private MatchMode mode = MatchMode.EightBallPro;
        [SerializeField] private float turnTimerSeconds = 35.0f;
        [SerializeField] private int maxFoulsAllowed = 3;
        [SerializeField] private bool allowBallInHandAnywhere = true;

        public MatchMode Mode => mode;
        public float TurnTimerSeconds => turnTimerSeconds;
        public int MaxFoulsAllowed => maxFoulsAllowed;
        public bool AllowBallInHandAnywhere => allowBallInHandAnywhere;

        public bool EvaluateMatchConclusion(int ballsRemaining, bool eightBallSunk, bool isScratch)
        {
            if (isScratch && eightBallSunk) return true; // Loss on scratch on 8-ball
            if (eightBallSunk && ballsRemaining == 0) return true; // Win on clean clearance
            return false;
        }
    }
}
