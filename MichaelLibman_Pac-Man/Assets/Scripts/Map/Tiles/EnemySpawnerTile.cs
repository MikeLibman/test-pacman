//
// EnemySpawnerTile.cs: 
//   Handles where enemies can spawn
//
// Author:
//   Michael Libman
//

public class EnemySpawnerTile : BaseTile 
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
        m_CollisionType = MapInfo.CollisionTypes.ENEMY_SPAWN;

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
