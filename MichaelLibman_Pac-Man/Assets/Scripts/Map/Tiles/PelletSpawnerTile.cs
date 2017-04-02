//
// PelletSpawnerTile.cs: 
//   Handles the pellet spawner tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class PelletSpawnerTile : BaseTile 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables
    private GameObject m_Pellet = null; // References to the spawned pellet

    // properties
    #endregion

    #region Unity API
    private void Awake()
    {
        gameObject.name = "Empty";                       // Set gameobject name to find sprite with the same name
        m_CollisionType = MapInfo.CollisionTypes.PELLET; // Change collision type to appropriate type

        AddComponents();
    }

    void Start () 
	{
        m_Pellet = Instantiate(GameManager.Instance.Pellet, transform); // Spawn a pellet as a child of the tile
        m_Pellet.name = "Pellet";                                       // Set name of gameobject for organizational purposes
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
}
