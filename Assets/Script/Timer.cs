using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool timer_on;
    public Text clock;

    static private float timer;


    private void Start()
    {
        clock.text = "Timer: " + timer.ToString("F0");
    }


    // Update is called once per frame
    void Update()
    {
    
        timer += Time.deltaTime;
        clock.text = "Timer: " + timer.ToString("F0");
        
    }

    public void ResetTimer()
    {
        timer = 0;
    }
}
