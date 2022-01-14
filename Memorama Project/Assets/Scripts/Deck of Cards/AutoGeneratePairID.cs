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

    public CardBehaviour actualCard;

    public List<Transform> unpairedCards = new List<Transform>();
    public List<Transform> pairedCards = new List<Transform>();

    #endregion

    #region Unity Methods

    void Start()
    {
        foreach(Transform e in GetComponent<CountAllCards>().cards)
            unpairedCards.Add(e);


    }

    #endregion

    #region Private Methods



    #endregion
}