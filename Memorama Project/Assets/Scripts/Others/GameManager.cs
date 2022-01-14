/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables

    [SerializeField] int cardsInScene;
    [SerializeField] GameObject gameOverUI;

    #endregion

    #region Unity Methods

    // Provisional: Cambiar a una forma más óptima para poder contar todas las cartas
    void Update()
    {
        // Si se acaban todas las cartas, aparecer la UI de GameOver
        cardsInScene = GameObject.FindGameObjectsWithTag("Card").Length;

        if (cardsInScene == 0)
            gameOverUI.SetActive(true);
    }

    #endregion

    #region Public Methods

    public void ResetGame()
    {
        Scene scene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(scene.name);
    }

    #endregion
}