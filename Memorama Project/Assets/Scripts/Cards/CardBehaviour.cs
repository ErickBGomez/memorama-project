/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class CardBehaviour : MonoBehaviour
{
    #region Events

    // Static para poder evitar las instancias de clase
    public delegate void PassPairIDHandler(CardBehaviour card);
    public static PassPairIDHandler PassPairID;

    // Se llamar� cuando se quiere cancelar una carta
    public delegate void CancelCardHandler();
    public static CancelCardHandler CancelCard;
    #endregion

    #region Variables

    [HideInInspector] public Animator animator;

    [HideInInspector] public CardInfo cardInfo;

    BoxCollider boxCollider;

    [HideInInspector] public bool waitingSecondCard;

    #endregion

    #region Unity Methods

    void Start()
    {
        animator = GetComponent<Animator>();

        cardInfo = GetComponent<CardInfo>();

        boxCollider = GetComponent<BoxCollider>();
    }

    private void OnMouseDown()
    {
        // Se activa la animaci�n para dar la vuelta
        animator.SetBool("isClicked", true);

        // Si se vuelve a dar click en la misma carta, se puede cancelar
        if (waitingSecondCard)
        {
            animator.SetBool("infoAnalyzed", true);

            if (CancelCard != null)
                CancelCard();
        }

    }

    // Estado actual: Falta hacer que las cartas regresen a su lugar una vez que hayan sido analizadas

    #endregion
    
    #region Public Methods

    // El evento de pasar el n�mero de par es activado cuando la animaci�n "CardShowFlip.anim" termina
    public void PassInfo()
    {
        if (PassPairID != null)
            PassPairID(this);
    }

    // Aqu� podemos establecar la variable que nos ayuda para saber que una carta est� esperando a una segunda.
    public void SetWaitingSecondCard()
    {
        waitingSecondCard = true;
    }

    public void ResetWaitingSecondCard()
    {
        waitingSecondCard = false;
    }

    // Las condiciones de las animaciones se reinician cuando la animaci�n "CardHideFlip.anim" termian
    public void ResetAnimations()
    {
        animator.SetBool("isClicked", false);
        animator.SetBool("infoAnalyzed", false);
    }

    // Esta funci�n es llamada cuando la animaci�n "CardDisappear.anim" termina
    public void DisappearCard()
    {
        Destroy(this.gameObject);
    }

    #endregion

    #region Private Methods

    void SetEnableCard(bool isEnable)
    {
        boxCollider.
    }

    #endregion

    #region Subscribe and Unsubscribe events

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    #endregion
}
