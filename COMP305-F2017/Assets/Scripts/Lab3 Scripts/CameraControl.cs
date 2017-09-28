using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public Transform player;
    public Transform area2;
    public Transform area3;
    public Camera cam;
    public int area;
    public float track;

    // Use this for initialization
    void Start()
    {

    }

    void Area(int num)
    {
        area = num;

        if(num == 3)
        {
            track = player.position.x;
        }        
    }

    // Update is called once per frame
    void Update()
    {

        if (area == 1)
        {
            Follow();
        }
        else if (area == 2)
        {
            ZoomOut();
        }
        else
        {            
            ZoomIn();
        }
    }

    void Follow()
    {
        this.transform.position = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        cam.orthographicSize = 4;
    }

    void ZoomOut()
    {
        this.transform.position = new Vector3(area2.position.x, area2.position.y, this.transform.position.z);
        cam.orthographicSize = 7;
    }

    void ZoomIn()
    {        
        this.transform.position = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        if (Input.GetKey(KeyCode.D) && player.position.x < area3.position.x+6.2f && cam.orthographicSize >= 1.2f && player.position.x >= track)
        {
            cam.orthographicSize -= 0.027f;
            track = player.position.x;
        }
    }
}
