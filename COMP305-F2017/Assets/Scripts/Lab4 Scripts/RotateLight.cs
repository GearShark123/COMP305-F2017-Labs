using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.back * 5f);
    }
}
