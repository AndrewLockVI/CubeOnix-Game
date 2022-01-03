using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class colorSet1 : MonoBehaviour
{
    

    public void red()
    {
        PlayerPrefs.SetString("color" , "red");
    }
    public void green()
    {
        if(PlayerPrefs.GetInt("green") == 1)
            {
                PlayerPrefs.SetString("color" , "green");
            }
    }
    public void blue()
    {
        if(PlayerPrefs.GetInt("blue") == 1)
         {
            PlayerPrefs.SetString("color" , "blue");
         }
    }
    public void purple()
    {
        if(PlayerPrefs.GetInt("purple") == 1)
        {
            PlayerPrefs.SetString("color" , "purple");
        }
    }
    public void orange()
    {
        if(PlayerPrefs.GetInt("orange") == 1)
        {
            PlayerPrefs.SetString("color" , "orange");
        }
    }

    public void pink()
    {
        if(PlayerPrefs.GetInt("pink") == 1)
        {
            PlayerPrefs.SetString("color" , "pink");
        }
    }
    public void yellow()
    {
        if(PlayerPrefs.GetInt("yellow") == 1)
        {
            PlayerPrefs.SetString("color" , "yellow");
        }
    }
    public void lightblue()
    {
        if(PlayerPrefs.GetInt("lightblue") == 1)
        {
            PlayerPrefs.SetString("color" , "lightblue");
        }
    }
    public void darkgreen()
    {
        if(PlayerPrefs.GetInt("darkgreen") == 1)
        {
            PlayerPrefs.SetString("color" , "darkgreen");
        }
    }
    public void brown()
    {
        if(PlayerPrefs.GetInt("brown") == 1)
        {
            PlayerPrefs.SetString("color" , "brown");
        }
    }
    public void maroon()
    {
        if(PlayerPrefs.GetInt("maroon") == 1)
        {
            PlayerPrefs.SetString("color" , "maroon");
        }
    }
    public void magenta()
    {
        if(PlayerPrefs.GetInt("magenta") == 1)
        {
            PlayerPrefs.SetString("color" , "magenta");
        }
    }
   



}
