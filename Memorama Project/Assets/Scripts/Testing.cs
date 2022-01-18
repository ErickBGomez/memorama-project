/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class Testing : MonoBehaviour
{
    #region Variables

    bool isPressing = false;
    public float value;
    public float holdDuration;

    Animator anim;

    #endregion

    #region Unity Methods

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isPressing)
        {
            value += Time.deltaTime;
        }
        else if (value > 0)
        {
            value -= Time.deltaTime;
        }
        else
        {
            value = 0;
        }

        if (value >= holdDuration)
        {
            Debug.Log("Se lleg� a su tiempo l�mite");
        }

        anim.speed = value;

        // La animaci�n cambia seg�n se va apretando el bot�n, ahora tengo que poner las respectivas transiciones y que �ste pueda devolverse con su estado original
    }

    #endregion

    #region Public Methods

    public void HoldDown()
    {
        isPressing = true;
    }

    public void HoldUp()
    {
        isPressing = false;
    }

    #endregion

    #region Private Methods



    #endregion
}