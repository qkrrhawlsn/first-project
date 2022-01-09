using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedShip : MonoBehaviour
{
    public GameObject ship001;
    public GameObject ship002;

    void Start()
    {
        if (PlayerPrefs.GetInt("ShipType") == 1)
        {
            ship001.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("ShipType") == 2)
        {
            ship002.SetActive(true);
        }
    }

}
