﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    public bool gvrStatus = false;
    public float gvrTimer = 0;

    public string sceneName;

    public int distanceOfRay  = 10;
    private RaycastHit _hit;

    public int counter;
    public Text countertext;

    public AudioSource grabsound;
    public AudioSource failsound;

    public Timer timeleft;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
     }

    // Update is called once per frame
    void Update()
    {
        
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        countertext.text = counter.ToString();

        //Debug.Log( " Status: " + gvrStatus);
        //Debug.Log(" Ray: " + ray);
        //Debug.Log(" Ray: " + Physics.Raycast(ray, out _hit, distanceOfRay)) ;

        if (Physics.Raycast(ray, out _hit, distanceOfRay)) {


            /*if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Menu1"))
            {
                _hit.transform.gameObject.GetComponent<SceneCtrl>().ChangeScene(sceneName);
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
            }

           */
            //Debug.Log("fill: " + imgGaze.fillAmount + " hit: " + _hit.transform.CompareTag("PointsStar") + " Status: " + gvrStatus);

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("PointsStar") && gvrStatus)
            {
                if (timeleft.TimeLeft > 0.0f)
                {
                    _hit.transform.gameObject.GetComponent<PointsStar>().Destroy();

                    counter++;
                    countertext.text = counter.ToString();
                    grabsound.Play();

                    gvrStatus = false;
                    gvrTimer = 0;
                    imgGaze.fillAmount = 0;

                }
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("PointsStar2") && gvrStatus)
            {
                if (timeleft.TimeLeft > 0.0f)
                {
                    _hit.transform.gameObject.GetComponent<PointsStar>().Destroy();
                    counter++;
                    counter++;
                    countertext.text = counter.ToString();
                    grabsound.Play();

                    gvrStatus = false;
                    gvrTimer = 0;
                    imgGaze.fillAmount = 0;
                }
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("PointsStar3") && gvrStatus)
            {
                if (timeleft.TimeLeft > 0.0f)
                {
                    _hit.transform.gameObject.GetComponent<PointsStar>().Destroy();
                    counter++;
                    counter++;
                    counter++;
                    countertext.text = counter.ToString();
                    grabsound.Play();

                    gvrStatus = false;
                    gvrTimer = 0;
                    imgGaze.fillAmount = 0;
                }
            }


            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("PointsStar4") && gvrStatus)
            {
                if (timeleft.TimeLeft > 0.0f)
                {
                    _hit.transform.gameObject.GetComponent<PointsStar>().Destroy();
                    counter--;
                    counter--;
                    counter--;
                    counter--;
                    counter--;
                    countertext.text = counter.ToString();
                    failsound.Play();

                    gvrStatus = false;
                    gvrTimer = 0;
                    imgGaze.fillAmount = 0;
                }
            }


        }
    }

    public void GVROn()
    {
        gvrStatus = true;

    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

}
