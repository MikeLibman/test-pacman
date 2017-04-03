//
// GameManager.cs: 
//   Manages the game state and other managers
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables
    private static GameManager m_Instance = null;

    [SerializeField]
    private GameObject m_Pellet;
    [SerializeField]
    private GameObject m_PowerPellet;
    [SerializeField]
    private ScoreManager m_ScoreManager;
    [SerializeField]
    private InputManager m_InputManager;
    [SerializeField]
    private GameFlowManager m_FlowManager;

    private List<BasePickup> m_Pellets = new List<BasePickup>();

    // properties
    public static GameManager Instance
    {
        get
        {
            return m_Instance;
        }
    }

    public GameObject Pellet // Holds the pellet prefab for the spawner tile
    {
        get
        {
            return m_Pellet;
        }
    }

    public GameObject PowerPellet // Holds the power pellet prefab for the spawner tile
    {
        get
        {
            return m_PowerPellet;
        }
    }

    public ScoreManager ScoreManager // Holds the score manager
    {
        set
        {
            m_ScoreManager = value;
        }

        get
        {
            return m_ScoreManager;
        }
    }

    public GameFlowManager FlowManager // Returns the flow manager
    {
        get
        {
            return m_FlowManager;
        }
    }

    public InputManager InputManager // Returns the input manager
    {
        get
        {
            return m_InputManager;
        }
    }
    #endregion

    #region Unity API
    private void Awake()
    {
        // Singleton madness!
        if (m_Instance == null)
        {
            m_Instance = this;
        }
        else if (m_Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        Assert.IsNotNull(m_Pellet, "Put a pellet object in the game manager");
        Assert.IsNotNull(m_PowerPellet, "Put a power pellet object in the game manager");
        Assert.IsNotNull(m_ScoreManager, "Put the score manager in the game manager");
    }
	#endregion

	#region Public Methods
    /// <summary>
    /// Register pellets to keep track of game state
    /// </summary>
    /// <param name="pellet">Pickups that are required to win</param>
    public void RegisterPellet(BasePickup pellet)
    {
        m_Pellets.Add(pellet); // Add pellet to list
    }

    /// <summary>
    /// Unregister pellets to keep track of game state.
    /// Once list reaches 0, player wins.
    /// </summary>
    /// <param name="pellet">Pickups that are required to win</param>
    public void UnregisterPellet(BasePickup pellet)
    {
        m_Pellets.Remove(pellet); // Remove pellet from list

        // If list is empty
        if (m_Pellets.Count == 0)
        {
            m_FlowManager.GameWon();
        }
    }

    /// <summary>
    /// Unregister all pellets for game
    /// reset purposes.
    /// </summary>
    public void UnregisterAllPellets()
    {
        m_Pellets.Clear();
    }
    #endregion

    #region Protected Methods

    #endregion

    #region Private Methods

    #endregion

    #region Interface Implementations

    #endregion
}
