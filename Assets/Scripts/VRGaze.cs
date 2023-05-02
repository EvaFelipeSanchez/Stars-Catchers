using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public float totalTime = 2;
    public bool gvrStatus = false;
    public float gvrTimer = 0;

    public int distanceOfRay  = 10;
    private RaycastHit _hit;

    private int counter;
    public Text countertext;


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

        //Debug.Log("fill: " + imgGaze.fillAmount + " hit: " + _hit.transform.CompareTag("PointsStar") + " Status: " + gvrStatus);
        //Debug.Log( " Status: " + gvrStatus);
        Debug.Log(" Ray: " + Physics.Raycast(ray, out _hit, distanceOfRay)) ;

        if (Physics.Raycast(ray, out _hit, distanceOfRay)) {


            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport"))
            {
                _hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
            }


            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Rotate") && gvrStatus)
            {
                _hit.transform.gameObject.GetComponent<Rotate>().ChangeSpin();
                gvrStatus = false;
            }
            
            
            Debug.Log("fill: " + imgGaze.fillAmount + " hit: " + _hit.transform.CompareTag("PointsStar") + " Status: " + gvrStatus);

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("PointsStar") && gvrStatus)
            {
                _hit.transform.gameObject.GetComponent<PointsStar>().Destroy();
                counter++;
                countertext.text = counter.ToString();
                gvrStatus = false;
                imgGaze.fillAmount = 0;
                gvrTimer = 0;
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
