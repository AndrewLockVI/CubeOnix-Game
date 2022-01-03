using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class storeOpen : MonoBehaviour
{
    public void openStore()
    {
        Invoke("storeOpen1" , .2f);

    }

    public void storeOpen1()
    {
        PlayerPrefs.SetInt("adrun" , 0);
        SceneManager.LoadScene("Store");
    }
}
