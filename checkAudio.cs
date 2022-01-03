using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAudio : MonoBehaviour
{


    void Update()
    {
        if( PlayerPrefs.GetString("sound") == "off")
        {
            AudioListener.pause = true;
        }

    }
}
