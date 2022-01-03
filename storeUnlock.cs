using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storeUnlock : MonoBehaviour
{
    public GameObject[] runsLock;
    public GameObject[] runsUnlock;
    public Text txtCost;
    



    void Update()
    {
 
        int cost = (PlayerPrefs.GetInt("owned") + 1) * 50;
        txtCost.text = "UNLOCK NEXT (" + cost + " credits)";
        
        if(PlayerPrefs.GetInt("purple") == 1 )
        {
            runsLock[0].SetActive(false);
            runsUnlock[0].SetActive(true);
        }
        

            runsLock[1].SetActive(false);
            runsUnlock[1].SetActive(true);
    
        if(PlayerPrefs.GetInt("blue") == 1 )
        {
            runsLock[2].SetActive(false);
            runsUnlock[2].SetActive(true);
        }
       
        if(PlayerPrefs.GetInt("green") == 1 )
        {
            runsLock[3].SetActive(false);
            runsUnlock[3].SetActive(true);
        }
        if(PlayerPrefs.GetInt("orange") == 1 )
        {
            runsLock[4].SetActive(false);
            runsUnlock[4].SetActive(true);
        }
        if(PlayerPrefs.GetInt("pink") == 1 )
        {
            runsLock[5].SetActive(false);
            runsUnlock[5].SetActive(true);
        }
        if(PlayerPrefs.GetInt("yellow") == 1 )
        {
            runsLock[6].SetActive(false);
            runsUnlock[6].SetActive(true);
        }
        if(PlayerPrefs.GetInt("lightblue") == 1 )
        {
            runsLock[7].SetActive(false);
            runsUnlock[7].SetActive(true);
        }
        if(PlayerPrefs.GetInt("darkgreen") == 1 )
        {
            runsLock[8].SetActive(false);
            runsUnlock[8].SetActive(true);
        }
        if(PlayerPrefs.GetInt("brown") == 1 )
        {
            runsLock[9].SetActive(false);
            runsUnlock[9].SetActive(true);
        }
        if(PlayerPrefs.GetInt("maroon") == 1 )
        {
            runsLock[10].SetActive(false);
            runsUnlock[10].SetActive(true);
        }
        if(PlayerPrefs.GetInt("magenta") == 1 )
        {
            runsLock[11].SetActive(false);
            runsUnlock[11].SetActive(true);
        }





    }


    public void unlockButton()
    {


        if (PlayerPrefs.GetInt("credits") >= 50 * (PlayerPrefs.GetInt("owned")  + 1) & PlayerPrefs.GetInt("owned") < 11)
        {            
            PlayerPrefs.SetInt("credits" , PlayerPrefs.GetInt("credits") - 50 * (PlayerPrefs.GetInt("owned")  + 1)) ;
            unlock();
            PlayerPrefs.SetInt("owned" ,  PlayerPrefs.GetInt("owned") + 1);         
            PlayerPrefs.SetString("firstbuy" , "notNow");   


        }
    }


    void unlock()
    {
       if(PlayerPrefs.GetInt("purple") != 1)
       {
           PlayerPrefs.SetInt("purple" , 1);
       }
        else if (PlayerPrefs.GetInt("blue") != 1)
       {
           PlayerPrefs.SetInt("blue" , 1);
       }
       else if (PlayerPrefs.GetInt("green") != 1)
       {
           PlayerPrefs.SetInt("green" , 1);
       }
       else if (PlayerPrefs.GetInt("orange") != 1)
       {
           PlayerPrefs.SetInt("orange" , 1);
       }
       else if (PlayerPrefs.GetInt("pink") != 1)
       {
           PlayerPrefs.SetInt("pink" , 1);
       }
       else if (PlayerPrefs.GetInt("yellow") != 1)
       {
           PlayerPrefs.SetInt("yellow" , 1);
       }
       else if (PlayerPrefs.GetInt("lightblue") != 1)
       {
           PlayerPrefs.SetInt("lightblue" , 1);
       }
       else if (PlayerPrefs.GetInt("darkgreen") != 1)
       {
           PlayerPrefs.SetInt("darkgreen" , 1);
       }
       else if (PlayerPrefs.GetInt("brown") != 1)
       {
           PlayerPrefs.SetInt("brown" , 1);
       }
       else if (PlayerPrefs.GetInt("maroon") != 1)
       {
           PlayerPrefs.SetInt("maroon" , 1);
       }
       else if (PlayerPrefs.GetInt("magenta") != 1)
       {
           PlayerPrefs.SetInt("magenta" , 1);
       }
      

    }


  





}