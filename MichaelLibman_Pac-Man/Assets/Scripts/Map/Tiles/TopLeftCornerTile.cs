//
// TopLeftCornerTile.cs: 
//   Handles the top left corner tile logic
//
// Author:
//   Michael Libman
//

public class TopLeftCornerTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "TopLeftCorner"; // Set gameobject name to find sprite with the same name

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
    }
    #endregion
}
