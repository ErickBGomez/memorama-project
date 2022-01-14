/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;
using System;

public class CountAllCards : MonoBehaviour
{

    #region Variables

    public Transform[] cards;

    #endregion

    #region Unity Methods

    // Se hace uso de Awake por el orden de la ejecuci�n de los m�todos de Unity: Awake va antes que Start, por lo tanto, le da tiempo para que el Script pueda registrar todas las cartas
    void Awake()
    {
        // Guardar todos los elementos child dentro del array (excluy�ndose a s� mismo). M�s info:
        // https://answers.unity.com/questions/817348/find-children-of-object-and-store-in-an-array.html
        cards = Array.FindAll(GetComponentsInChildren<Transform>(), card => card.tag == "Card");

        // Si el link anterior se pierde, mejor buscar el tema "Lambda expression"

        Debug.Log(cards.Length);
    }

    #endregion
}