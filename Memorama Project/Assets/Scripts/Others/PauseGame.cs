/*
*********************************
 Script made by: Erick B. Gomez
 https://github.com/ErickBGomez
*********************************
*/

using UnityEngine;

public class PauseGame : MonoBehaviour
{
    #region Events

    public delegate void SetCardColliderHandler(bool isEnable);
    public static event SetCardColliderHandler SetCardCollider;

    #endregion

    #region Variables



    #endregion

    #region Unity Methods

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    #endregion

    #region Public Methods



    #endregion

    #region Private Methods

    void SetPause(bool isPaused)
    {
        if (isPaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

        if (SetCardCollider != null)
            SetCardCollider(!isPaused);
    }

    #endregion

    #region Subscribe and Unsubscribe Events

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    #endregion
}