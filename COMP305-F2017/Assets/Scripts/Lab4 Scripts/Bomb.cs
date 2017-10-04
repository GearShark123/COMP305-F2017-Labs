using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    private int counter;

    // Use this for initialization
    void Start () {
        counter = 0;
        Invoke("MakeExplosion",3f);
	}	

    void MakeExplosion()
    {
        // Create Explosion 
    }
}
