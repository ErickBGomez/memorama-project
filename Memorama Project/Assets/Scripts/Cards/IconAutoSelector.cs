/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class IconAutoSelector : MonoBehaviour
{
    #region Variables

    [SerializeField] Sprite[] icons;

    SpriteRenderer spriteRenderer;
    CardInfo cardInfo;

    #endregion

    #region Unity Methods

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Se accede al Script "CardInfo" del elemento padre
        cardInfo = transform.parent.GetComponent<CardInfo>();

        // Tenemos un Array guardado con todos los �conos posibles, el cual, coinciden con el PairID. Por lo tanto, se le va a asignar el �cono con el mismo index al valor num�rico del PairID de CardInfo
        spriteRenderer.sprite = icons[cardInfo.pairID];
    }

    #endregion
}