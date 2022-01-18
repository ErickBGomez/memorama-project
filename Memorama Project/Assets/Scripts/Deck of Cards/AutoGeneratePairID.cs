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

    Transform[] allCards;

    // Variable que nos ayuda a poder bloquear cuando se encuentran cartas repetidas en la selección aleatoria
    bool isCardRepeated;
    // Nos ayuda a guardar el valor aleatorio en el que se eligen las cartas
    int randomIndex;
    // Nos ayuda a poder guarda la carta que ha sido seleccionada y así lo podemos comparar en la lista para ver si existe o no
    Transform cardSelected;
    // Nos ayuda a poder alternar el valor del PairID, aumentándolo de valor por cada 2 veces que se pasa en el bucle. Tanto éste y la siguiente variable empiezan en -1 para poder empezar con el bucle de alternar valores
    int alternatePairIDModule = -1;
    // Establece el nuevo PairID para la carta
    int newPairID = -1;
    // Lista de cartas mezcladas
    public List<Transform> shuffledCardsList = new List<Transform>();


    #endregion

    #region Unity Methods

    void OnEnable()
    {
        // Conseguir referencia del mazo
        allCards = GetComponent<CountAllCards>().cards;
        
        // Seleccionar las cartas de forma aleatoria
        while (shuffledCardsList.Count < allCards.Length)
        {
            // Iniciamos con false, ya que el bucle se tiene que reiniciar
            isCardRepeated = false;

            // Escoger un índice aleatorio en allCards 
            randomIndex = Random.Range(0, allCards.Length);

            // Tomar esa carta
            cardSelected = allCards[randomIndex];

            // Verificar si no existe en el mazo
            foreach (Transform card in shuffledCardsList)
            {
                // Si la carta existe en shuffledCardsList, terminar el bucle foreach
                if (cardSelected == card)
                {
                    isCardRepeated = true;

                    break;
                }
            }

            // Si la carta no existe: Agregar carta a shuffledCardsList
            if (!isCardRepeated)
            {
                // Seleccionar el nuevo PairID, alternando su valor cada dos veces que se pasa en esta condicional
                alternatePairIDModule++;

                if (alternatePairIDModule%2 == 0)
                    newPairID++;

                // Agregar la carta en la lista mezclada
                shuffledCardsList.Add(cardSelected);

                // Escoger el nuevo PairID para la última carta guardada en shuffledCardsList
                shuffledCardsList[shuffledCardsList.Count - 1].gameObject.GetComponent<CardInfo>().pairID = newPairID;
            }
        }
    }

    #endregion
}