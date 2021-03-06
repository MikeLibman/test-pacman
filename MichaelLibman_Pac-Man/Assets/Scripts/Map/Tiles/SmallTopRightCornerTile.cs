﻿//
// SmallTopRightCornerTile.cs: 
//   Handles the small top right corner tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class SmallTopRightCornerTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "SmallTopRightCorner"; // Set gameobject name to find sprite with the same name

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

        m_BoxCollider2D.size = new Vector2(4, 4);     // Set collider size to fit corner
        m_BoxCollider2D.offset = new Vector2(-2, -2); // Set collider offset to fit corner
    }
    #endregion
}
