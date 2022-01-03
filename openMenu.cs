using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openMenu : MonoBehaviour
{
    public void menuSwitch()
    {
        PlayerPrefs.SetString("animation" , "no");
        Invoke("menuOpen" , .2f);

    }

    public void menuOpen()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
