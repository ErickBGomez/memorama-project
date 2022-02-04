/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class DebugMessages
{
    #region Events

    public delegate void GenerateErrorMessageHandler(string messsage);
    public static event GenerateErrorMessageHandler GenerateErrorMessage;

    #endregion

    #region Variables



    #endregion

    #region Public Methods

    public static void ErrorMessage(string message)
    {
        Debug.LogError(message);

        if (GenerateErrorMessage != null)
            GenerateErrorMessage(message);
    }

    #endregion

    #region Private Methods



    #endregion

}