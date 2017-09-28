using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArea : MonoBehaviour {

    public Camera cam;
    public int num;

    void OnTriggerEnter2D(Collider2D collision)
    {        
            cam.SendMessage("Area", num);        
    }
}
