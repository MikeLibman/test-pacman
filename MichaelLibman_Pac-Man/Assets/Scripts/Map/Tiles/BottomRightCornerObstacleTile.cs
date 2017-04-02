//
// BottomRightCornerObstacleTile.cs: 
//   Handles the bottom right corner obstacle tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class BottomRightCornerObstacleTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "BottomRightCornerObstacle"; // Set gameobject name to find sprite with the same name

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

        m_BoxCollider2D.size = new Vector2(4, 4);    // Set collider size to fit corner
        m_BoxCollider2D.offset = new Vector2(-2, 2); // Set collider size to fit corner
    }
    #endregion
}
