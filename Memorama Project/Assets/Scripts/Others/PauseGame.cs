/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class PauseGame : MonoBehaviour
{
    #region Events

    public delegate void SetCardColliderHandler(bool isEnable);
    public static event SetCardColliderHandler SetCardCollider;

    #endregion

    #region Variables

    [Header("Pause")]
    [SerializeField] GameObject pauseMenu;

    [Header("Set Groups Interactuable")]
    [SerializeField] CanvasGroup pauseButtonGroup;
    [SerializeField] CanvasGroup resetButtonGroup;

    #endregion


    #region Public Methods

    public void SetPause(bool isPaused)
    {
        if (isPaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

        pauseMenu.SetActive(isPaused);
        pauseButtonGroup.interactable = !isPaused;
        resetButtonGroup.interactable = !isPaused;

        if (SetCardCollider != null)
            SetCardCollider(!isPaused);
    }

    #endregion
}