using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGMControl : MonoBehaviour
{

    private int[] items;
    public Text bolt;
    public Text nut;
    public Text screw;

    // Use this for initialization
    void Start()
    {
        GameObject gm = GameObject.Find("GM");
        gm.SendMessage("Items");

        bolt.text = items[0] + "";
        nut.text = items[1] + "";
        screw.text = items[2] + "";
    }

    void GetItems(int[] loot)
    {
        items = loot;
    }
}
