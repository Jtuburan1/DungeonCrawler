using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovementDetails_", menuName = "Scriptable Objects/Movement/MovementDetails")]
public class MovementDetailsSO : ScriptableObject
{
    #region Header MOVEMENT DETAILS
    [Space(10)]
    [Header("MOVEMENT DETAILS")]
    #endregion

    #region Tooltip
    [Tooltip("The minimum move speed. the GetMoveSpeed method calculates a random value between the minimum and maximum")]
    #endregion
    public float minMoveSpeed = 8f;

    #region Tooltip
    [Tooltip("The maximum move speed. the GetMoveSpeed method calculates a random value between the minimum and maximum")]
    #endregion
    public float maxMoveSpeed = 8f;

    #region Tooltip
    [Tooltip("If there is a roll movement - this is the roll speed")]
    #endregion
    public float rollSpeed; // for player

    #region Tooltip
    [Tooltip("If there is a roll movement - this is the roll distance")]
    #endregion
    public float rollDistance; // for player

    #region Tooltip
    [Tooltip("If there is a roll movement - this is he cooldown time")]
    #endregion
    public float rollCooldownTime; // for player

    public float GetMoveSpeed()
    {
        if(minMoveSpeed == maxMoveSpeed)
        {
            return minMoveSpeed;
        }
        else
        {
            return Random.Range(minMoveSpeed, maxMoveSpeed);
        }
    }


    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckPositiveRange(this, nameof(minMoveSpeed), minMoveSpeed, nameof(maxMoveSpeed), maxMoveSpeed, false);

        if (rollDistance != 0f || rollSpeed != 0f || rollCooldownTime != 0)
        {
            HelperUtilities.ValidateCheckPositiveValue(this, nameof(rollDistance), rollDistance, false);
            HelperUtilities.ValidateCheckPositiveValue(this, nameof(rollSpeed), rollSpeed, false);
            HelperUtilities.ValidateCheckPositiveValue(this, nameof(rollCooldownTime), rollCooldownTime, false);
        }
    }
#endif
    #endregion Validation
}
