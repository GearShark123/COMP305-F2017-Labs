using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform player;
    public Transform area2;
    public Camera cam;
    public int area;

	// Use this for initialization
	void Start () {
        
	}
	
    void Area(int num)
    {
        area = num;
    }

	// Update is called once per frame
	void Update () {

        if(area == 1)
        {
            Follow();
        }
        else if (area == 2)
        {
            ZoomOut();
        }
    }

    void Follow()
    {
        this.transform.position = new Vector3(player.position.x, player.position.y, this.transform.position.z);
    }

    void ZoomOut()
    {
        this.transform.position = new Vector3(area2.position.x, area2.position.y, this.transform.position.z);
        cam.orthographicSize = 7;
    }
}
