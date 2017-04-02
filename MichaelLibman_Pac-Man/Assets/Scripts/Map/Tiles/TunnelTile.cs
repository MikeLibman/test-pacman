//
// TunnelTile.cs: 
//   Handles the tunnel tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class TunnelTile : BaseTile 
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
        gameObject.name = "Empty";                        // Set gameobject name to find sprite with the same name
        m_CollisionType = MapInfo.CollisionTypes.TUNNEL;  // Change collision type to appropriate type

        AddComponents();
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Adds components based on the base class
    /// </summary>
    public override void AddComponents()
    {
        base.AddComponents();
    }
    #endregion

    #region Protected Methods

    #endregion

    #region Private Methods

    #endregion
}
