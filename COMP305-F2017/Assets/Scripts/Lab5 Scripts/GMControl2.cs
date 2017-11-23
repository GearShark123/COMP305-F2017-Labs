using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMControl2 : MonoBehaviour
{
    public GameObject bolt;
    public GameObject nut;
    public GameObject screw;

    private int num;
    private int[] items;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    void Start()
    {

        items = new int[3];

        for (int i = 0; i < 30; i++)
        {
            num = Random.Range(0, 3);

            if (num == 0)
            {
                Instantiate(bolt, new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0), Quaternion.identity);
            }
            else if (num == 1)
            {
                Instantiate(nut, new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0), Quaternion.identity);
            }
            else
            {
                Instantiate(screw, new Vector3(Random.Range(-8, 9), Random.Range(-4, 5), 0), Quaternion.identity);
            }

        }
    }

    void Collected(string item)
    {
        if (item == "bolt")
        {
            items[0] += 1;
        }
        else if (item == "nut")
        {
            items[1] += 1;
        }
        else
        {
            items[2] += 1;
        }
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene("Lab5 Part2");
    }

    void Items()
    {
        int[] loot = items;
        GameObject gm = GameObject.Find("InventoryGM");
        gm.SendMessage("GetItems", loot);
    }
}
