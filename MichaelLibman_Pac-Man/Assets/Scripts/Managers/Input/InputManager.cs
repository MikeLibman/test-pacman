//
// InputManager.cs: 
//   Handles when input is used
//
// Author:
//   Michael Libman
//

using UnityEngine;

public class InputManager : MonoBehaviour
{
    #region Members & Properties
    // consts
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    // enums

    // structs

    // public variables

    // private variables
    private Vector2 m_MoveDirection = Vector2.zero;

    // properties
    public Vector2 MoveDirection
    {
        get
        {
            return m_MoveDirection;
        }
    }
    #endregion

    #region Unity API
    void Update()
    {
        // If game is over, end game
        if (GameManager.Instance.FlowManager.IsGameOver)
        {
            return;
        }

        // If game isn't already started and use presses the space bar
        if (!GameManager.Instance.FlowManager.HasGameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.FlowManager.StartGame(); // Start the game
        }

        // If the game has started and the user presses the 'P' key
        if (GameManager.Instance.FlowManager.HasGameStarted && Input.GetKeyDown(KeyCode.P))
        {
            GameManager.Instance.FlowManager.TogglePause(); // Toggle between paused and unpaused
        }

        // If the game has started and the game is paused
        if (GameManager.Instance.FlowManager.HasGameStarted && GameManager.Instance.FlowManager.IsGamePaused)
        {
            return; // Don't continute update
        }

        // Gets movement input
        if (Input.GetAxis(VERTICAL) > 0)
        {
            m_MoveDirection = Vector2.up;
        }
        else if (Input.GetAxis(HORIZONTAL) < 0)
        {
            m_MoveDirection = Vector2.left;
        }
        else if (Input.GetAxis(VERTICAL) < 0)
        {
            m_MoveDirection = Vector2.down;
        }
        else if (Input.GetAxis(HORIZONTAL) > 0)
        {
            m_MoveDirection = Vector2.right;
        }
    }
	#endregion

	#region Public Methods

	#endregion

	#region Protected Methods

	#endregion

	#region Private Methods

	#endregion

	#region Interface Implementations

	#endregion
}
