//
// PlayerSpawnerTile.cs: 
//   Handle where the player will spawn
//
// Author:
//   Michael Libman
//

public class PlayerSpawnerTile : BaseTile 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables

    // properties
    #endregion

    #region Unity API
    private void Awake()
    {
        gameObject.name = "Empty";
        m_CollisionType = MapInfo.CollisionTypes.PLAYER_SPAWN;

        AddComponents();
    }
    #endregion

    #region Public Methods
    public override void AddComponents()
    {
        base.AddComponents();
    }
    #endregion
}
