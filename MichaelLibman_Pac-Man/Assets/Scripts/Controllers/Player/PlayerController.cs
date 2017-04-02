//
// PlayerController.cs: 
//   Handles the player movement, collisions,
///  animations and SFX
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables
    [SerializeField]
    private float m_MovementSpeed = 50;

    private bool m_IsCollidingWithWall = false; // Is player colliding with a wall?

    private Vector2 m_MoveDirection = Vector2.zero;

    private Animator m_Animator;

    private AudioSource m_AudioSource;

    // properties

    #endregion

    #region Unity API
    void Start () 
	{
        m_Animator = GetComponent<Animator>();
        m_AudioSource = GetComponent<AudioSource>();
	}
	
	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_MoveDirection = Vector2.up;

            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            m_MoveDirection = Vector2.left;

            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            m_MoveDirection = Vector2.down;

            transform.eulerAngles = new Vector3(0, 0, 270);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            m_MoveDirection = Vector2.right;

            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        m_Animator.SetBool("IsCollidingWithWall", m_IsCollidingWithWall); // Set animation based on if player is moving or not

        // If player is not touching a wall
        if (!m_IsCollidingWithWall)
        {
            transform.Translate(m_MoveDirection * Time.deltaTime * m_MovementSpeed, Space.World); // Move in the chosen direction
            
            // If the SFX is not playing ...
            if (!m_AudioSource.isPlaying)
            {
                m_AudioSource.Play(); // Play it
            }
        }
    }

    void OnCollisionEnter2D(Collision2D _collider)
    {
        BaseTile collider = _collider.gameObject.GetComponent<BaseTile>(); // Get a BaseTile collider

        // If the collider is a BaseTile collider with the collision type of WALL ...
        if (collider != null && collider.CollisionType.Equals(MapInfo.CollisionTypes.WALL))
        {
            // The player is colliding with a wall so stop movement and SFX
            m_IsCollidingWithWall = true;
            m_AudioSource.Stop();
        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        m_IsCollidingWithWall = false; // Allow movement again
    }
    #endregion

    #region Public Methods

    #endregion

    #region Protected Methods

    #endregion

    #region Private Methods

    #endregion
}
