using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showRevive : MonoBehaviour
{
    public AdRevive adClass;
    public GameObject buttonShow;

    public GameObject playAgainHidden;
    public GameObject playAgain;


    void Update()
    {
        if( adClass.checkAd() == true)
        {
            buttonShow.SetActive(true);

        }
        else
        {
            buttonShow.SetActive(false);
            playAgain.SetActive(false);
            playAgainHidden.SetActive(true);

        }
    }
}
