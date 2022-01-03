using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour , IUnityAdsListener
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


    public void PlayAd()
    {
        if (Advertisement.IsReady("RewardCoin"))
        {
            PlayerPrefs.SetInt("adrun" , 1);
            Advertisement.Show("RewardCoin");
        }
        else if (Advertisement.IsReady("RewardCoin"))
        {
            PlayerPrefs.SetInt("adrun" , 1);
            Advertisement.Show("RewardCoin");
        }
        
    }

    public bool AdCheck()
    {
       if (Advertisement.IsReady("RewardCoin"))
        {
            return true;
        } 
        else if (Advertisement.IsReady("RewardCoin"))
        {
            return true;
        }
        return false;
    }







    public void OnUnityAdsReady(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(showResult == ShowResult.Finished & placementId == "RewardCoin")
        {
            payout();
        }

    }
    public void payout()
    {
        if(PlayerPrefs.GetInt("adrun") != 0)
        {
        PlayerPrefs.SetInt("credits" , PlayerPrefs.GetInt("credits") + 50);
        PlayerPrefs.SetInt("adrun" , 0);
        }

    }
}
