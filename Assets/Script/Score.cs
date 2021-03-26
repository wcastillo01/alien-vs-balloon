using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreValue = 0;
    Text ScoreText;
    public GameObject Retry;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text> ();
        InvokeRepeating(nameof(Perdidahelio), 10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Helium: " + ScoreValue;

        if(ScoreValue < 0)
        {
            Time.timeScale = 0;
            ScoreText.text = "Helium: 0";
            Retry.SetActive(true);
        }

        //if(ScoreValue >= 500)
        //{
        //    Time.timeScale = 0;
        //    ScoreText.text = "Helium: 500+";
        //    Winner.SetActive(true);
        //}

    }

    void Perdidahelio()
    {
        ScoreValue -= 5;
    }

}
