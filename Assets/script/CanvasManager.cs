using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
                Time.timeScale = 0;
                pausePanel.SetActive(true);
        }
         if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene("Unity");
            Time.timeScale = 1;            
         }
    }
    

    public void Restart(){
        SceneManager.LoadScene("Unity");
         Time.timeScale = 1;
           
        }
        
    
    public void GameOver(){
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }
     public void Reprendre(){
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void Quitter(){
        Application.Quit();
    }

    public void Menu(){    
        SceneManager.LoadScene("MenuPrincipal"); 
    }

}
