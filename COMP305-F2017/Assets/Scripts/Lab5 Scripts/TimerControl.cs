using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerControl : MonoBehaviour
{
    public GameObject gm;
    public Text timer;
    private float num;
    private bool loadOnce = false;

    // Use this for initialization
    void Start()
    {

        timer = GetComponent<Text>();
        timer.text = "30";
    }

    // Update is called once per frame
    void Update()
    {
        num = 5 - Time.realtimeSinceStartup;

        if (num > 0f)
        {
            timer.text = string.Format("{0:f1}", num);
            if ((int)num == 0.0)
            {
                if (loadOnce == false)
                {
                    gm.SendMessage("LoadNewScene");
                    loadOnce = true;
                }
            }
        }


    }
}