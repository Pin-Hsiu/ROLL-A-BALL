﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public static int time;
    public static int timer_i = 10;
    Text text;

    void Start()
    {
        

        InvokeRepeating("timer", 1f, 1f);
        text = GetComponent<Text>();
        time = 0;
    }
    void timer()
    {
        if (timer_i > 0)
            timer_i -= 1;
        //Debug.Log(timer_i);
    }



    void Update()
    {
        text.text = "TIME: " + timer_i ;
        if (timer_i <= 0)
        {
            text.text = "Time's up.";
        }
    }

    
}