//
// BaseTile.cs: 
//   Base tile class that handles all 
//   basic tile functionality.
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class BaseTile : Tile 
{
    #region Members & Properties
    // consts
    protected const string TILE_SPRITE_SHEET_NAME = "BackgroundTiles"; // Name of the tile sprite sheet
    
    // enums

    // structs

    // public variables

    // protected variables
    protected MapInfo.CollisionTypes m_CollisionType = MapInfo.CollisionTypes.WALL; // Set the base collision type for tiles
    protected BoxCollider2D m_BoxCollider2D = null;

    // private variables

    // properties
    public MapInfo.CollisionTypes CollisionType
    {
        get
        {
            return m_CollisionType; // Returns the tile's collision type
        }
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Add componments to tiles and 
    /// prepare the tile for use
    /// </summary>
    public override void AddComponents()
    {
        gameObject.AddComponent<BoxCollider2D>();  // Add a box collider 2D
        gameObject.AddComponent<SpriteRenderer>(); // Add a sprite renderer

        m_BoxCollider2D = GetComponent<BoxCollider2D>();
        m_BoxCollider2D.size = new Vector2(8, 8); // Scale up the collider to fit the tile size

        SetSprite(); // Set the tile's sprite
    }
    #endregion

    #region Protected Methods
    /// <summary>
    /// Load the sprite sheet from resources
    /// and find / use the proper sprite
    /// </summary>
    protected void SetSprite()
    {
        Sprite[] tileSprites = Resources.LoadAll<Sprite>("Sprites\\" + TILE_SPRITE_SHEET_NAME); // Look in Resources folder for  sprite sheet

        // Safety first
        if (tileSprites == null || tileSprites.Length <= 0)
        {
            return;
        }

        // Rip through all the tiled sprites
        for (int i = 0; i < tileSprites.Length; i++)
        {
            // If there's a tile sprite with the name of our gameobject ...
            if (tileSprites[i].name.Equals(gameObject.name))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = tileSprites[i]; // Set the sprite to the renderer
                break;
            }
        }
    }
    #endregion
}