/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class WindowParameters : MonoBehaviour
{
    #region Variables

    Animator animator;

    #endregion

    #region Unity Methods

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    #endregion

    #region Public Methods

    public void SetWindowActive(bool boolValue)
    {
        if (boolValue)
        {
            this.gameObject.SetActive(true);
            animator.SetBool("isActive", true);
        }
        else
        {
            animator.SetBool("isActive", false);
        }
    }

    public void DisappearWindow()
    {
        this.gameObject.SetActive(false);
    }

    #endregion
}