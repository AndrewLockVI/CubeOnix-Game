using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getCredits : MonoBehaviour
{
  public Text credits;
  
    void Update()
    {
        credits.text = PlayerPrefs.GetInt("credits") + "";
    }
}
