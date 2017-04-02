//
// PowerPelletPickup.cs: 
//   Handles the power pellet pick up logic
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PowerPelletPickup : BasePickup 
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
    void Start () 
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_BoxCollider = GetComponent<BoxCollider2D>();
        m_AudioSource = GetComponent<AudioSource>();

        RegisterItem(); // Register the pellet to the game manager
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Register the pellet to the game manager 
    /// through the base class
    /// </summary>
    public override void RegisterItem()
    {
        base.RegisterItem();
    }

    /// <summary>
    /// Unregister the pellet from the game manager 
    /// through the base class
    /// </summary>
    public override void UnregisterItem()
    {
        base.UnregisterItem();
    }
    #endregion

    #region Protected Methods

    #endregion

    #region Private Methods

    #endregion
}
