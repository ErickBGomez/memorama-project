/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using System.Collections.Generic;
using UnityEngine;

public class CardPairIDCheck : MonoBehaviour
{
    #region Variables

    bool value;

    [Header("List of cards")]
    public List<CardBehaviour> cards = new List<CardBehaviour>();

    [Header("Update Score reference")]
    [SerializeField] UpdateScore score;
    [SerializeField] int scoreWhenMatchingCards;

    #endregion

    #region Private Methods

    void ReceivePairID(CardBehaviour card)
    {
        // Asegura que hayan dos cartas en la lista
        if (cards.Count < 2)
            cards.Add(card);

        // Si la lista ya contiene dos cartas:
        if (cards.Count == 2)
        {
            // Asegurar que se le pase el dato "infoAnalyzed" como forma de seguridad para sus animaciones
            foreach (CardBehaviour e in cards)
                e.animator.SetBool("infoAnalyzed", true);

            // Si las cartas tienen el mismo PairID, establecer que son pareja, de lo contrario, no.
            if (cards[0].cardInfo.pairID == cards[1].cardInfo.pairID)
            {
                // Establecer que son pareja
                SetPair(true);

                score.UpdateScoreNum(scoreWhenMatchingCards);
            }
            else
            {
                // Establecer que no son pareja. Esto es mas bien simbólico, porque no hay necesidad de hacer esto, pero es para dar orden en el algoritmo
                SetPair(false);
            }

            // Limpiar la lista una vez que se hayan analizado los PairID de las cartas
            RemoveCards();
        }
    }

    // Establecer que las cartas seleccionadas son pareja o no dependiendo del resultado dado
    void SetPair(bool isPairedUp)
    {
        foreach (CardBehaviour e in cards)
            e.animator.SetBool("pairedUp", isPairedUp);
    }

    void RemoveCards()
    {
        cards.Clear();
    }

    #endregion

    #region Subscribe and Unsubscribe Events

    private void OnEnable()
    {
        CardBehaviour.PassPairID += ReceivePairID;
        CardBehaviour.CancelCard += RemoveCards;
    }

    private void OnDisable()
    {
        CardBehaviour.PassPairID -= ReceivePairID;
        CardBehaviour.CancelCard -= RemoveCards;
    }

    #endregion
}
