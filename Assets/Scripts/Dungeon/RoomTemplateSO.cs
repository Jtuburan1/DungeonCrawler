using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Room_", menuName = "Scriptable Objects/Dungeon/Room")]
public class RoomTemplateSO : ScriptableObject
{
    [HideInInspector] public string guid;

    #region Header

    [Space(10)]
    [Header("ROOM PREFAB")]

    #endregion

    #region Tooltip
    [Tooltip("The gameobject prefab for the room ( this will contain all the tilemaps for the room and environment game objects")]
    #endregion

    public GameObject prefab;

    [HideInInspector] public GameObject previousPrefab; // this is used to regenerate the guid if the SO is copied and the prefab is changed

    #region Header ROOM CONFIGURATION

    [Space(10)]
    [Header("ROOM CONFIGURATION")]

    #endregion

    #region Tooltip
    [Tooltip(" The room node type SO. The room node types correspond to the room nodes used in the room node graph.  The exceptions being with corridors. In the room node graph there is just one corridor type 'Corridor'. For the room templates there are 2 corridor node types - CorridorNS and CorridorEW.")]
    #endregion

    public RoomNodeTypeSO roomNodeType;

    #region Tooltip
    [Tooltip("If you imagine a rectangle around the room tilemap that just completely encloses it, the room lower bounds represent the bottom left corner of that rectangle. This should be determined from the tilemap for the room (using the coordinate brush pointer to get the tilemap grid position for that bottom left corner (Note: this is the local tilemap position and NOT world position")]
    #endregion

    public Vector2Int lowerBounds;


}
