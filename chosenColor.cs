using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosenColor : MonoBehaviour
{
  
    public GameObject red;
    public GameObject blue;

    public GameObject green;

    public GameObject purple;

    public GameObject orange;
    public GameObject pink;
    public GameObject yellow;
    public GameObject lightblue;
    public GameObject darkgreen;
    public GameObject brown;
    public GameObject maroon;
    public GameObject magenta;


    void Update()
    {
        if(PlayerPrefs.GetString("color") == "" | PlayerPrefs.GetString("color") == "red")
        {
            red.SetActive(true);
        }
        else
        {
            red.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "blue")
        {
            blue.SetActive(true);
        }
        else
        {
            blue.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "green")
        {
            green.SetActive(true);
        }
        else
        {
            green.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "purple")
        {
            purple.SetActive(true);
        }
        else
        {
            purple.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "orange")
        {
            orange.SetActive(true);
        }
        else
        {
            orange.SetActive(false);
        }



        if(PlayerPrefs.GetString("color") == "pink")
        {
            pink.SetActive(true);
        }
        else
        {
            pink.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "yellow")
        {
            yellow.SetActive(true);
        }
        else
        {
            yellow.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "lightblue")
        {
            lightblue.SetActive(true);
        }
        else
        {
            lightblue.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "darkgreen")
        {
            darkgreen.SetActive(true);
        }
        else
        {
            darkgreen.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "brown")
        {
            brown.SetActive(true);
        }
        else
        {
            brown.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "maroon")
        {
            maroon.SetActive(true);
        }
        else
        {
            maroon.SetActive(false);
        }
        if(PlayerPrefs.GetString("color") == "magenta")
        {
            magenta.SetActive(true);
        }
        else
        {
            magenta.SetActive(false);
        }
        















        
    }
}
