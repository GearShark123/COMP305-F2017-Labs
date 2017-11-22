using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerControl : MonoBehaviour
{

    //public Component Timer;

    Text timer;
    float time;
    float num;

    // Use this for initialization
    void Start()
    {

        timer = GetComponent<Text>();
        timer.text = "30";
    }

    // Update is called once per frame
    void Update()
    {
        num = 30 - Time.realtimeSinceStartup;
        while (num > 0)
        {
            timer.text = string.Format("{0:f1}", num);            
        }
        
    }
}