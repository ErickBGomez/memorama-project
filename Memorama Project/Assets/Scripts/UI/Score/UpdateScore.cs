/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    #region Variables

    public int score;

    TextMeshProUGUI scoreText;

    #endregion

    #region Unity Methods

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        score = 0;

        UpdateScoreNum(score);
    }

    #endregion

    #region Public Methods

    public void UpdateScoreNum(int addScore)
    {
        score += addScore;

        scoreText.text = score.ToString();
    }


    #endregion
}
