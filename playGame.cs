using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playGame : MonoBehaviour
{



    public void changeScreen()
    {
        PlayerPrefs.SetInt("startLocation" , 0);
        Invoke("gameOpen" , .2f);

    }

    public void gameOpen()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
}
