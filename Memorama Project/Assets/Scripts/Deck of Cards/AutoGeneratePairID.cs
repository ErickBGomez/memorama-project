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


    bool isCardRepeated;
    int randomIndex;
    Transform cardSelected;
    public List<Transform> allCards2 = new List<Transform>();


    #endregion

    #region Unity Methods

    void OnEnable()
    {
        // Conseguir referencia del mazo
        allCards = GetComponent<CountAllCards>().cards;

        /*
        // Agregar aleatoriamente el índice de las cartas
        foreach(Transform card in allCards)
        {
            randomPairID = Random.Range(0, allCards.Length / 2);

            card.GetComponent<CardInfo>().pairID = randomPairID;
        }*/
                


        while (allCards2.Count < allCards.Length)
        {
            // Iniciamos con false, ya que el bucle se tiene que reiniciar
            isCardRepeated = false;

            // Escoger un índice aleatorio en allCards 
            randomIndex = Random.Range(0, allCards.Length);

            // Tomar esa carta
            cardSelected = allCards[randomIndex];

            // Verificar si no existe en el mazo
            foreach (Transform card in allCards2)
            {
                // Si la carta existe en allCards2, terminar el bucle foreach
                if (cardSelected == card)
                {
                    isCardRepeated = true;

                    break;
                }
            }

            // Si no existe: Agregar carta
            if (!isCardRepeated)
                allCards2.Add(cardSelected);

        }
        

        // Establecer el número del PairID (dos veces el mismo valor, luego, aumentar ++)



    }

    #endregion

    #region Private Methods



    #endregion
}