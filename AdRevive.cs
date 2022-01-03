using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class AdRevive : MonoBehaviour, IUnityAdsListener
{


    #if UNITY_IOS
        string gameId = "4536250";
    #else
        string gameId = "4536251";
    #endif


     void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId);
    }

    public bool checkAd()
    {
        if ( Advertisement.IsReady("Rewarded_Android") == true)
        {
            return true;
        }
        if ( Advertisement.IsReady("Rewarded_iOS") == true)
        {
            return true;
        }

        return false;
    }

    public void showAds()
    {
        if ( Advertisement.IsReady("Rewarded_Android") == true)
        {
            Advertisement.Show("Rewarded_Android");
        }
        if ( Advertisement.IsReady("Rewarded_iOS") == true)
        {
            Advertisement.Show("Rewarded_iOS");
        }
    }





    public void OnUnityAdsDidError(string message)
    {
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(showResult == ShowResult.Finished & (placementId == "Rewarded_Android" | placementId == "Rewarded_iOS"))
        {
        PlayerPrefs.SetInt("fromad" , 1);
        PlayerPrefs.SetInt("LoadNum" , 1);
        SceneManager.LoadScene("SampleScene");
        }


    }
 

    public void OnUnityAdsDidStart(string placementId)
    {
    }

    public void OnUnityAdsReady(string placementId)
    {
    }
}
