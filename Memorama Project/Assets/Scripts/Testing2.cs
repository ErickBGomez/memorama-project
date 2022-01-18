/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class Testing2 : MonoBehaviour
{
    #region Variables

    Animation anim;
    AnimationCurve animCurve;

    AnimationClip animClip;

    #endregion

    #region Unity Methods

    void Start()
    {
        anim = GetComponent<Animation>();
        animCurve = AnimationCurve.Linear(0.0f, 1.0f, 2.0f, 0.0f);

        animClip = new AnimationClip();
        animClip.legacy = true;
        animClip.SetCurve("", typeof(Transform), "localPosition.x", animCurve);

        anim.AddClip(animClip, "test");
        anim.Play("test");
    }

    void Update()
    {
        
    }

    #endregion

    #region Public Methods



    #endregion
}