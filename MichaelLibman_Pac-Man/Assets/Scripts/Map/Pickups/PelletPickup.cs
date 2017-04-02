//
// PelletPickup.cs: 
//   Handles the pellet pickup logic
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class PelletPickup : BasePickup 
{
	#region Unity API
	void Start () 
	{
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_BoxCollider = GetComponent<BoxCollider2D>();
        m_AudioSource = GetComponent<AudioSource>();

        RegisterItem(); // Register the pellet to the game manager
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Register the pellet to the game manager 
    /// through the base class
    /// </summary>
    public override void RegisterItem()
    {
        base.RegisterItem();
    }

    /// <summary>
    /// Unregister the pellet from the game manager 
    /// through the base class
    /// </summary>
    public override void UnregisterItem()
    {
        base.UnregisterItem();
    }
    #endregion
}
