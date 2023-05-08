using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class VRGazeMenu : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent GVRClick;

    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    public AudioSource clicksound;


    // Start is called before the first frame update
    void Start()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if(gvrTimer > totalTime)
        {
            clicksound.Play();
            GVRClick.Invoke();
            
        }

        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        /*if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Menu1"))
            {
                _hit.transform.gameObject.GetComponent<SceneCtrl>().ChangeScene(sceneName);
                 gvrStatus = false;
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Menu2"))
            {
                _hit.transform.gameObject.GetComponent<SceneCtrl>().QuitApp();
                gvrStatus = false;
            }

        }
        */
    }

    public void GVROn()
    {
        gvrStatus = true;
        

    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }
}
