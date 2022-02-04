/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;
using TMPro;

public class ErrorDebugUIBehaviour : MonoBehaviour
{
    #region Variables

    [SerializeField] TextMeshProUGUI textMesh;
    [SerializeField] GameObject bg;

    #endregion

    #region Private Methods

    void GenerateErrorMessage(string message)
    {
        bg.SetActive(true);

        textMesh.color = Color.red;

        textMesh.text = "Error: " + message;
    }

    #endregion

    #region Subscribe and Unsubscribe Events

    private void OnEnable()
    {
        DebugMessages.GenerateErrorMessage += GenerateErrorMessage;
    }

    private void OnDisable()
    {
        DebugMessages.GenerateErrorMessage -= GenerateErrorMessage;
    }

    #endregion
}