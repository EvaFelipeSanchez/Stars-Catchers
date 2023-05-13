using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneChanger : MonoBehaviour
{

    [SerializeField] Timer timer;
    [SerializeField] VRGaze gaze;
    [SerializeField] SpawnObject spawn;


    //public bool repeatactivated = false;

    public CanvasController canvas1;
    public CanvasController canvas2;

    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
    }

    public void QuitScene(string scenemenu)
    {

        SceneManager.LoadScene(scenemenu);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void RepeatScene()
    {

   
        canvas1.ShowCanvas();
        canvas2.HideCanvas();
        timer.TimeLeft = 60;
        timer.StartTime = 3;
        timer.timerOn = false;


        gaze.counter = 0;
        gaze.imgGaze.fillAmount = 0;
        gaze.gvrStatus = false;
        spawn.timerOn = true;
        //repeatactivated = true;



    }




}