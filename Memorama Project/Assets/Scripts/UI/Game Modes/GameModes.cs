/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;
public class GameModes : MonoBehaviour
{
    #region Variables

    [SerializeField] GameObject basicUI;

    #endregion
    

    #region Public Methods

    public void StartGameMode(int gameMode)
    {
        
        switch (gameMode)
        {
            case 0:

                // Ejecutar tutorial
                Debug.Log("Tutorial empezado");

                break;

            case 1:

                // Ejecutar levels
                Debug.Log("Levels empezado");

                break;

            case 2:

                // Ejecutar Times Up
                Debug.Log("Time's Up empezado");

                break;

            case 3:

                // Ejecutar Sudden Death
                Debug.Log("Sudden Death empezado");

                break;
        }

        basicUI.SetActive(true);

        this.gameObject.SetActive(false);

        // Ahora tengo que ver una forma para poder hacer que se ejecuten todo el proceso de cartas con el orden debido
        
    }

    #endregion
}