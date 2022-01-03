using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class runAnimation : MonoBehaviour
{
    public GameObject box;
   

    void Update()
    {

     if (PlayerPrefs.GetInt("credits") >= 50 * (PlayerPrefs.GetInt("owned")  + 1) & PlayerPrefs.GetInt("owned") < 11 )
     {
        box.GetComponent<Animator>().enabled = true;
        box.GetComponent<Animator>().Play("ExpandingBuy");
     }
     else
     {
         box.GetComponent<Animator>().enabled = false;
     }
    }
}
