using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        PlayerPrefs.SetInt("ShipType", 1);
    }

    public void goToSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }
}

