/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class DisableCanvasGroupOnPause : MonoBehaviour
{
    #region Variables

    CanvasGroup canvasGroup;

    #endregion

    #region Unity Methods

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    #endregion

    #region Private Methods

    void DisableOnPause(bool boolValue)
    {
        canvasGroup.interactable = boolValue;
    }

    #endregion

    #region Subscribe and Unsubscribe Events

    private void OnEnable()
    {
        ControlsManager.DisableActionsOnPauseMenu += DisableOnPause;
    }

    private void OnDisable()
    {
        ControlsManager.DisableActionsOnPauseMenu -= DisableOnPause;
    }

    #endregion
}