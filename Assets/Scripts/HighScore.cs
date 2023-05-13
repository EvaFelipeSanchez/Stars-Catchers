using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] VRGaze counter;
    [SerializeField] Timer timeleft;
    [SerializeField] SceneChanger scene;

    public int high;
    public Text highscore;

    // Start is called before the first frame update
    public void updatehigh()
    {
    
        if (timeleft.TimeLeft <= 0.0f)
        {
            if (counter.counter > high)
            {
                high = counter.counter;
                highscore.text = counter.counter.ToString("f0");
            }
            //Debug.Log(counter.counter);
        }
  

    }


}
