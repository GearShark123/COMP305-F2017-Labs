using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMControl : MonoBehaviour
{
    public GameObject bomb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bomb, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, this.transform.position.z + 10f)), this.transform.rotation);
        }
    }
}
