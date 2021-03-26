﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ScoreValue = 0;
    Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + ScoreValue;
    }
}
