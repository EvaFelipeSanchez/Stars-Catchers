using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VRGazeMenu : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public string sceneName;

    public int distanceOfRay = 10;
    private RaycastHit _hit;


    // Start is called before the first frame update
    void Start()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
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

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
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
