using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideScript : MonoBehaviour
{
    public GameObject pan;
    void Start()
    {
        if(PlayerPrefs.GetString("animation") == "")
        {
        Invoke("Disable" , .25f);
        }
        else
        {
            PlayerPrefs.SetString("animation" , "");
            pan.SetActive(false);
        }
    }
    void Disable()
    {
        pan.SetActive(false);
    }

    
}
