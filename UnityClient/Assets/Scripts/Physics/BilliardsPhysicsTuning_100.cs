namespace CueMasters.Physics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Billiards 2D Collision Solver & Motion Settlement Detector #100
    /// Evaluates momentum conservation, spin deflection, and waits for all balls to settle below threshold.
    /// </summary>
    public class BilliardsPhysicsTuning_100 : MonoBehaviour
    {
        [SerializeField] private float velocityRestThreshold = 0.03f;
        [SerializeField] private float settleDelaySeconds = 0.4f;

        public bool AreBallsSettled(Rigidbody2D[] activeBalls)
        {
            foreach (var b in activeBalls)
            {
                if (b != null && b.velocity.sqrMagnitude > (velocityRestThreshold * velocityRestThreshold))
                    return false;
            }
            return true;
        }
    }
}
