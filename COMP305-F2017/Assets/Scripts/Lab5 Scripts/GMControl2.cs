using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMControl2 : MonoBehaviour {

    public GameObject bolt;
    public GameObject nut;
    public GameObject screw;

    private int num;

    // Use this for initialization
    void Start () {

        for (int i = 0; i <= 30; i++)
        {
            num = Random.Range(0, 3) + 1;

            if (num == 1)
            {
                Instantiate(bolt, new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0), Quaternion.identity);
            }
            else if (num == 2)
            {
                Instantiate(nut, new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0), Quaternion.identity);
            }
            else
            {
                Instantiate(screw, new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0), Quaternion.identity);
            }
            i++;
        }
	}
	
	// Update is called once per frame
	void Update () {
        //print(num = Random.Range(-1, 2));

    }
}
