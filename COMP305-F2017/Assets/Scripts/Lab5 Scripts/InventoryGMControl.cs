using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGMControl : MonoBehaviour {

    public int[] items;
    public Text bolt;
    public Text nut;
    public Text screw;

    // Use this for initialization
    void Start () {
        GameObject gm = GameObject.Find("GM");
        gm.SendMessage("Items");

        //bolt = GetComponent<Text>();
        //bolt.text = items[0] + "";
        //nut = GetComponent<Text>();
        //nut.text = items[1] + "";
        //screw = GetComponent<Text>();
        //screw.text = items[2] + "";

        foreach (int i in items)
        {
            print(i);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void GetItems(int[] loot)
    {
        items = loot;
    }
}
