//
// ScoreManager.cs: 
//   Manages the player's score
//
// Author:
//   Michael Libman
//

using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
    #region Members & Properties
    // consts

    // enums

    // structs

    // public variables

    // private variables
    [SerializeField]
    private Text m_GameScoreText;

    private int m_GameScore = 0;

    // properties
    public int GameScore
    {
        set
        {
            m_GameScore = value;

            if (m_GameScore < 0)
            {
                m_GameScore = 0;
            }

            m_GameScoreText.text = GameScore.ToString();
        }

        get
        {
            return m_GameScore;
        }
    }
    #endregion

    #region Unity API
    private void Awake()
    {
        Assert.IsNotNull(m_GameScoreText, "Put the game score text in the score manager");
    }
	#endregion

}
