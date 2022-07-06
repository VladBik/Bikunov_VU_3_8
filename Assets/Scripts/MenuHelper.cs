using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System; 

public class MenuHelper : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenuCanvas;

    public void Play()
    {
        SceneManager.LoadScene(1);

    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Pause1()
    {

        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
