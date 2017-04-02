//
// CherrySpawnerTile.cs: 
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

public class CherrySpawnerTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "CherrySpawner";
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
