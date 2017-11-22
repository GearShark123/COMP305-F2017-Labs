using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerControl : MonoBehaviour {

    //public Component Timer;

    Text timer;
    float time;
    
    // Use this for initialization
    void Start () {

        timer = GetComponent<Text>();
        timer.text = "30";
	}
	
	// Update is called once per frame
	void Update () {
        timer.text = string.Format("{0:f1}", (30 - Time.realtimeSinceStartup));
    }
}
