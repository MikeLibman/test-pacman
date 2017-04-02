//
// BasePickup.cs: 
//   Base class for all pickups
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;

public class BasePickup : Pickup 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // protected variables
    [SerializeField]
    protected int m_PickupValue = 0;

    protected SpriteRenderer m_SpriteRenderer;

    protected BoxCollider2D m_BoxCollider;

    protected AudioSource m_AudioSource;

    // private variables

    // properties
    public int PickupValue
    {
        get
        {
            return m_PickupValue; // Get the score value of the pick
        }
    }
    #endregion

    #region Unity API
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag.Equals("Player"))
        {
            PickupItem();     // Pickup the item
            UnregisterItem(); // Unregister the item from the game manager
        }
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// When the user picks up an item
    /// disable the sprite renderer and box collider.
    /// </summary>
    public override void PickupItem()
    {
        GameManager.Instance.ScoreManager.GameScore += m_PickupValue;

        m_AudioSource.Play();

        m_SpriteRenderer.enabled = false;
        m_BoxCollider.enabled = false;
    }

    /// <summary>
    /// Register the item to the game manager
    /// </summary>
    public override void RegisterItem()
    {
        GameManager.Instance.RegisterPellet(this);
    }

    /// <summary>
    /// Unregister the item from the game manager
    /// </summary>
    public override void UnregisterItem()
    {
        GameManager.Instance.UnregisterPellet(this);
    }
    #endregion

    #region Protected Methods

    #endregion

    #region Private Methods

    #endregion
}
