//
// EmptyTile.cs: 
//   Handles the empty tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class EmptyTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "Empty";                      // Set gameobject name to find sprite with the same name
        m_CollisionType = MapInfo.CollisionTypes.EMPTY; // Change collision type to appropriate type

        AddComponents();
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Adds components and sets sprite
    /// </summary>
    public override void AddComponents()
    {
        gameObject.AddComponent<SpriteRenderer>(); // Add a sprite renderer

        SetSprite(); // Set the empty sprite
    }
    #endregion
}
