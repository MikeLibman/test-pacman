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
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameFlowManager : MonoBehaviour 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables
    [SerializeField]
    private Image m_ReadyImage;
    [SerializeField]
    private Image m_ClearImage;
    [SerializeField]
    private Image m_GameOverImage;

    // properties
    #endregion

    #region Unity API
    private void Awake()
    {
        Assert.IsNotNull(m_ReadyImage, "Put ready image in the game flow manager");
        Assert.IsNotNull(m_ClearImage, "Put clear image in the game flow manager");
        Assert.IsNotNull(m_GameOverImage, "Put game over image in the game flow manager");
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
