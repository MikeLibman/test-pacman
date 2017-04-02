//
// LeftWallGhostHouseTile.cs: 
//   Handles the left wall ghost house tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class LeftWallGhostHouseTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "LeftWallGhostHouse"; // Set gameobject name to find sprite with the same name

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

        m_BoxCollider2D.size = new Vector2(4, 8);   // Set collider size to fit wall
        m_BoxCollider2D.offset = new Vector2(2, 0); // Set collider offset to fit wall
    }
    #endregion
}
