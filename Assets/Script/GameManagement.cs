using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject FireButton;
    public GameObject JumpButton;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 0;
        
    }

    public void PlayButton()
    {
        MainMenu.SetActive(false);
        FireButton.SetActive(true);
        JumpButton.SetActive(true);
        Time.timeScale = 1;
    }
    
}
