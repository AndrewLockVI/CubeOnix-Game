using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnButton : MonoBehaviour
{
    public GameObject onButton;
    public GameObject offButton;
    public void mute()
    {
        offButton.SetActive(true);
        onButton.SetActive(false);
        AudioListener.pause = true;
        PlayerPrefs.SetString("sound" , "off");

    }

    public void unmute()
    {
        offButton.SetActive(false);
        onButton.SetActive(true);
        AudioListener.pause = false;
        PlayerPrefs.SetString("sound" , "on");
    }
}
