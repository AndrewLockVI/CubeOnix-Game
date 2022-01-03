using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showNotification : MonoBehaviour
{
    public GameObject notify;

    void Update()
    {
        if(PlayerPrefs.GetInt("credits") >= 50 * (PlayerPrefs.GetInt("owned")  + 1) & PlayerPrefs.GetInt("owned") < 11 & PlayerPrefs.GetInt("runs") > 0)
        {
            notify.SetActive(true);
        }
        else
        {
            notify.SetActive(false);
        }
    }
}
