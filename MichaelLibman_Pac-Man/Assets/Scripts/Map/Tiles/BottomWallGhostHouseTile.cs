//
// BottomWallGhostHouseTile.cs: 
//   Handles the bottom wall ghost house tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class BottomWallGhostHouseTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "BottomWallGhostHouse"; // Set gameobject name to find sprite with the same name

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

        m_BoxCollider2D.size = new Vector2(8, 4);   // Set collider size to fit wall
        m_BoxCollider2D.offset = new Vector2(0, 2); // Set collider offset to fit wall
    }
    #endregion
}
