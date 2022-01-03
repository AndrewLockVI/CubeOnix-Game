using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMain : MonoBehaviour
{
    public GameObject soundOn;
    public GameObject soundOff;
    // Start is called before the first frame update
    void Start()
    {

        if(PlayerPrefs.GetString("sound") == "off")
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            AudioListener.pause = true;

        }
  
    }

   
}
