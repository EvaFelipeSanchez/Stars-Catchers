using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool timerOn = false;

    public Text TimerTxt;
    void Start()
    {
        timerOn = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            TimeLeft -= Time.deltaTime;
            updateTimer(TimeLeft);
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}
