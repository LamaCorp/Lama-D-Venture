using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour { 

    public void LaunchCollab() 
    {
        SceneManager.LoadScene(2);
    }



    public void QuitGame()
    {
        Debug.Log("QuittedGame");
        Application.Quit();
    }
}   