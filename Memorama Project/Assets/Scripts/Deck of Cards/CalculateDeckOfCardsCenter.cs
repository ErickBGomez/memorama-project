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

    // Referencia del GameObject vacío para poder posicionar la cámara
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

        // Interpolación lineal a de la mitad entre la primera y la última carta del mazo
        deckOfCardsCenter.position = Vector3.Lerp(allCards[0].position, allCards[allCards.Length - 1].position, 0.5f);

        // Tomamos la distancia en Z de la cámara y le sumamos el resultado de la interpolación lineal
        cam.transform.position = new Vector3(0, 0, cam.transform.position.z) + deckOfCardsCenter.position;
    }

    #endregion
}