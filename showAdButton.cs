using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class showAdButton : MonoBehaviour
{
    public GameObject buttonForAd;
    public AdsManager ad;



    void Start()
    {
        if(ad.AdCheck() == true)
        {
            buttonForAd.SetActive(true);
        
        }
        else
        {
            buttonForAd.SetActive(false);
        }


      
       
    }

    
}
