/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class AutoArrangeDeckOfCards : MonoBehaviour
{
    #region Variables

    Transform[] totalCards;

    [Range(1f, 3f)] public float distanceBetweenCards;

    public int columns, rows;

    #endregion

    #region Unity Methods

    void Start()
    {
        // Tomar el mazo de cartas guardados en la clase "CountAllCards"
        totalCards = GetComponent<CountAllCards>().cards;


        // Calcular las columnas y filas

        CalculateColumnsAndRows();
        

        // Reordenar todos los children (por cuestiones de seguridad)
        foreach (Transform card in totalCards)
        {
            card.position = this.transform.position;
        }

        // Verificar si la cantidad de cartas total es par
        if (totalCards.Length % 2 == 0)
        {
            // Verificar si los elementos encajan en el mazo correctamente
            if (columns * rows == totalCards.Length)
            {

                // Separar objetos

                // Variable que calcula la altura de la fila que tendrán las cartas de la fila actual
                float yRow;
                // Variable que calcula todas las iteraciones hechas por ambos bucles
                int k = 0;
                // Calcular las filas
                for (int i = 0; i < rows; i++)
                {
                    yRow = distanceBetweenCards * i;

                    // Calcular las columnas
                    for (int j = 0; j < columns; j++)
                    {
                        // Usamos "k" en children porque no se reiniciará su valor cuando se sale del bucle
                        // -yRow porque queremos que el cálculo de la altura sea hacia abajo
                        totalCards[k].position = new Vector2(distanceBetweenCards * j, -yRow);
                        k++;
                    }
                }

            }
            else
            {
                // En el caso que se tenga un número de elementos que no cuadran perfectamente, mostrar este mensaje de error
                Debug.LogError("Se ha identificado un número de elementos que no cuadran en un mazo. Por favor, ingrese otro número");
            }
        }
        else
        {
            // En el caso que la cantidad de cartas no sea par, mostrar este mensaje de error
            Debug.LogError("Se ha detectado que la cantidad total de cartas no es par. Reingrese el número de cartas e inténtelo nuevamente");
        }

        transform.position = Vector3.zero;
    }

    #endregion

    #region Private Methods

    void CalculateColumnsAndRows()
    {
        // Raíz cuadrada de la cantidad de elementos presentes para poder hacer el cálculo del cuadrado o rectángulo
        rows = (int)Mathf.Sqrt(totalCards.Length);
        // El resultado de la raíz anterior será usado en la división entre el número de elementos presentes entre la raíz, así podemos encajar cada elemento en cuadros ordenados
        columns = totalCards.Length / rows;

        PrintInfo();
    }

    void PrintInfo()
    {
        Debug.Log($"Columns: {columns}, Rows: {rows}");
    }

    #endregion
}