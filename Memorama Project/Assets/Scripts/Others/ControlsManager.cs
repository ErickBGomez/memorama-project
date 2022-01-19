/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class ControlsManager : MonoBehaviour
{
    #region Events

    public delegate void DisableActionsOnPauseMenuHandler(bool boolValue);
    public static event DisableActionsOnPauseMenuHandler DisableActionsOnPauseMenu;

    #endregion

    #region Variables

    [SerializeField] GameObject pauseMenuUI;

    #endregion

    #region Unity Methods

    void Update()
    {
        // Activar y desactivar el menú de pausa (por medio de la tecla "Esc")

        if (Input.GetKeyDown(KeyCode.Escape) && !pauseMenuUI.activeInHierarchy)
            ShowOrHidePauseMenu(true);
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseMenuUI.activeInHierarchy)
            ShowOrHidePauseMenu(false);
    }

    #endregion

    #region Public Methods

    public void ShowOrHidePauseMenu(bool boolValue)
    {
        pauseMenuUI.SetActive(boolValue);
        pauseMenuUI.GetComponent<WindowParameters>().SetWindowActive(boolValue);

        if (DisableActionsOnPauseMenu != null)
            DisableActionsOnPauseMenu(!boolValue);

        if (boolValue)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    #endregion
}