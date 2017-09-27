using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public Transform spawn;
    public GameObject sprite;

    void OnMouseDown()
    {     
        Destroy(GameObject.Find("Lyle Self Portrait (Green)(Clone)"));
        Destroy(GameObject.Find("Lyle Self Portrait (Blue)(Clone)"));
        Destroy(GameObject.Find("Lyle Self Portrait (Red)(Clone)"));
        Instantiate(sprite, spawn.transform.position, spawn.transform.rotation);            
    }
}
