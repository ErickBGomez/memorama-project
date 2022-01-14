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

    int randomPairID;

    Transform[] allCards;

    #endregion

    #region Unity Methods

    void OnEnable()
    {
        allCards = GetComponent<CountAllCards>().cards;

        foreach(Transform card in allCards)
        {
            randomPairID = Random.Range(0, allCards.Length / 2);

            card.GetComponent<CardInfo>().pairID = randomPairID;
        }
    }

    #endregion

    #region Private Methods



    #endregion
}