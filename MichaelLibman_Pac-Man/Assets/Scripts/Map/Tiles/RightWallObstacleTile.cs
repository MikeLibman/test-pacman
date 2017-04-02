//
// RightWallObstacleTile.cs: 
//   Handles the right wall tile obstacle logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class RightWallObstacleTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "RightWallObstacle"; // Set gameobject name to find sprite with the same name

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
