using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Startagain : MonoBehaviour
{
    public void restart()
    {
        PlayerPrefs.SetInt("startLocation" , 0);
        Invoke("gameSetOpen" , .2f);

    }

    public void gameSetOpen()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
