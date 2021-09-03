using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    
    public Text timerText;
  


    TimeSpan timer = new TimeSpan();
    
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "00:00:000";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0f)
        {
            timer = timer.Add(TimeSpan.FromSeconds(Time.deltaTime));
            timerText.text = timer.Minutes.ToString("00") + ":" + timer.Seconds.ToString("00") + ":" + timer.Milliseconds.ToString("000");
        }
        
    }
}
