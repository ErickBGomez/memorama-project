/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;
using System.Collections.Generic;

public class AutoGeneratePairID : MonoBehaviour
{
    #region Variables

    Transform[] totalCards;
    public CardBehaviour actualCard;

    public List<Transform> pairedCards = new List<Transform>();

    #endregion

    #region Unity Methods

    void Start()
    {
        // Acceder a las cartas registradas en el mazo
        totalCards = GetComponent<CountAllCards>().cards;

        // Tomar una carta aleatoria
        // Error: El indez de totalCards es igual a 0.
        Debug.Log(totalCards.Length);

        actualCard = totalCards[Random.Range(0, totalCards.Length - 1)].GetComponent<CardBehaviour>();
    }

    #endregion

    #region Private Methods



    #endregion
}