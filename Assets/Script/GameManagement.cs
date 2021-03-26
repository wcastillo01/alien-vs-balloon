using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject PauseMenu;
    public GameObject Retry;
    public GameObject Buttons;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 0;
        
    }

    public void PlayButton()
    {
        MainMenu.SetActive(false);
        Buttons.SetActive(true);
        Time.timeScale = 1;
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Retry.SetActive(false);
        MainMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ResumeButton()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
