//
// GameFlowManager.cs: 
//   Handles the flow of the game
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class GameFlowManager : MonoBehaviour 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables
    [SerializeField]
    private Image m_StartImage;
    [SerializeField]
    private Image m_ReadyImage;
    [SerializeField]
    private Image m_ClearImage;
    [SerializeField]
    private Image m_GameOverImage;

    private bool m_HasGameStarted = false;
    private bool m_IsGamePaused = false;
    private bool m_IsGameOver = false;

    // properties
    public bool HasGameStarted // Returns if the game has started
    {
        get
        {
            m_StartImage.enabled = !m_HasGameStarted; // Toggle the start image

            return m_HasGameStarted;
        }
    }

    public bool IsGamePaused // Returns if the game is paused
    {
        get
        {
            m_ReadyImage.enabled = m_IsGamePaused; // Toggle the ready image

            return m_IsGamePaused;
        }
    }

    public bool IsGameOver // Returns if the game is over
    {
        get
        {
            return m_IsGameOver;
        }
    }
    #endregion

    #region Unity API
    private void Awake()
    {
        Assert.IsNotNull(m_StartImage, "Put start image in the game flow manager");
        Assert.IsNotNull(m_ReadyImage, "Put ready image in the game flow manager");
        Assert.IsNotNull(m_ClearImage, "Put clear image in the game flow manager");
        Assert.IsNotNull(m_GameOverImage, "Put game over image in the game flow manager");
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Starts the game
    /// </summary>
    public void StartGame()
    {
        m_HasGameStarted = true;
        m_IsGameOver = false;

        m_StartImage.enabled = false;
        m_ReadyImage.enabled = false;
        m_ClearImage.enabled = false;
        m_GameOverImage.enabled = false;

        GameManager.Instance.ScoreManager.GameScore = 0;
    }

    /// <summary>
    /// Stops the game
    /// </summary>
    public void StopGame()
    {
        m_HasGameStarted = false;
    }

    /// <summary>
    /// Sets if the game is paused or not
    /// </summary>
    public void TogglePause()
    {
        m_IsGamePaused = !m_IsGamePaused;
    }

    /// <summary>
    /// Ends game and shows game over screen
    /// </summary>
    public void GameLost()
    {
        m_IsGameOver = true;
        m_HasGameStarted = false;
        m_GameOverImage.enabled = m_IsGameOver;
    }

    /// <summary>
    /// Ends game and shows clear screen
    /// </summary>
    public void GameWon()
    {
        m_IsGameOver = true;
        m_HasGameStarted = false;
        m_ClearImage.enabled = m_IsGameOver;
    }
    #endregion
}
