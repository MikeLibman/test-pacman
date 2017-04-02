//
// PowerPelletSpawnerTile.cs: 
//   Handles the power pellet spawner tile logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class PowerPelletSpawnerTile : BaseTile 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables
    private GameObject m_PowerPellet = null; // References to the spawned power pellet

    // properties
    #endregion

    #region Unity API
    private void Awake()
    {
        gameObject.name = "Empty";                             // Set gameobject name to find sprite with the same name
        m_CollisionType = MapInfo.CollisionTypes.POWER_PELLET; // Change collision type to appropriate type

        AddComponents();
    }

    void Start () 
    {
        m_PowerPellet = Instantiate(GameManager.Instance.PowerPellet, transform); // Spawn a power pellet as a child of the tile
        m_PowerPellet.name = "PowerPellet";                                       // Set name of gameobject for organizational purposes
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
