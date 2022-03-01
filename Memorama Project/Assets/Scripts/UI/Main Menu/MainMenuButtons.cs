/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    #region Variables

    public string sceneName;

    #endregion

    #region Public Methods
    
    public void StartGame()
    {
        // Iniciar escenario para poder iniciar la partida

        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        // Cerrar el juego

        Application.Quit();
    }

    #endregion
}