using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreC : MonoBehaviour
{

    [SerializeField] VRGaze counter;

    public Text score;
    // Start is called before the first frame update
    private void Update()
    {
        //Debug.Log(counter.counter);
        score.text = counter.counter.ToString("f0");
    }



}
