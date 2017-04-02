//
// BottomRightCornerTile.cs: 
//   Handles the bottom right corner tile logic
//
// Author:
//   Michael Libman
//

public class BottomRightCornerTile : BaseTile 
{
    #region Unity API
    private void Awake()
    {
        gameObject.name = "BottomRightCorner"; // Set gameobject name to find sprite with the same name

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
