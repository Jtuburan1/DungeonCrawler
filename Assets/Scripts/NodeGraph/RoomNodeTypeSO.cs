using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType_", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    #region Header
    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    #endregion
    public bool displayInNodeGraphEditor = true;
    #region Header
    [Header("One Type Should Be A Corridor")]
    #endregion
    public bool isCorridor;
    #region Header
    [Header("One Type Should Be A CorridorNS")]
    #endregion
    public bool isCorridorNS;
    #region Header
    [Header("One Type Should Be A CorridorEW")]
    #endregion
    public bool isCorridorEW;
    #region Header
    [Header("One Type Should Be An Entrance")]
    #endregion
    public bool isEntrance;
    #region Header
    [Header("One Type Should Be A Boss Room")]
    #endregion
    public bool isBossRoom;
    #region Header
    [Header("One Type Should Be None (Unassigned)")]
    #endregion
    public bool isNone;


    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }
#endif
    #endregion
}
