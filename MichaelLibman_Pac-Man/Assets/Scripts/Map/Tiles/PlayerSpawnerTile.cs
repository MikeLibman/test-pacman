//
// PlayerSpawnerTile.cs: 
//   [SUMMARY OF SCRIPT]
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerSpawnerTile : BaseTile 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables

    // properties
    #endregion

    #region Unity API
    private void Awake()
    {
        gameObject.name = "PlayerSpawner";
        m_CollisionType = MapInfo.CollisionTypes.PLAYER_SPAWN;

        AddComponents();
    }

    void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}
    #endregion

    #region Public Methods
    public override void AddComponents()
    {
        base.AddComponents();
    }
    #endregion

    #region Protected Methods

    #endregion

    #region Private Methods

    #endregion

    #region Interface Implementations

    #endregion
}
