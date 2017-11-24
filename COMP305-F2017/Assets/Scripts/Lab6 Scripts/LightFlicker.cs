using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightFlicker : MonoBehaviour
{
    public Light light;
    private System.Random random = new System.Random();
    private bool isLess = false;
    public float maxValue;  // 15
    public float minValue;  // 12
    public float change;    // 0.1

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (light.intensity + change <= maxValue && isLess == true)
        {
            light.intensity += change; 
            if (light.intensity == maxValue)
            {
                isLess = false;
            }
        }
        else
        {
            light.intensity -= change;
            if (light.intensity <= minValue)
            {
                isLess = true;
            }
        }
    }
}
