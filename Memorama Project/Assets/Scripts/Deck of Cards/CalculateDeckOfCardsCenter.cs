/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class CalculateDeckOfCardsCenter : MonoBehaviour
{
    #region Variables

    // Referencia del GameObject vac�o para poder posicionar la c�mara
    public Transform deckOfCardsCenter;

    Camera cam;
    // Obtener todas las cartas del mazo
    Transform[] allCards;


    #endregion

    #region Unity Methods

    void Start()
    {
        allCards = GetComponent<CountAllCards>().cards;

        cam = Camera.main;

        // Interpolaci�n lineal a de la mitad entre la primera y la �ltima carta del mazo
        deckOfCardsCenter.position = Vector3.Lerp(allCards[0].position, allCards[allCards.Length - 1].position, 0.5f);

        // Tomamos la distancia en Z de la c�mara y le sumamos el resultado de la interpolaci�n lineal
        cam.transform.position = new Vector3(0, 0, cam.transform.position.z) + deckOfCardsCenter.position;
    }

    #endregion
}