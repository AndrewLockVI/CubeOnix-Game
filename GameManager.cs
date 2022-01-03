using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject deadUI;
    public Text highscore;
    public Text distance;
    public Text lastRun;
    public Text highScore;
    public Text credits;
    public GameObject canvas;
    public Text average;
    public Text runs;
    public GameObject firstTime;
    public GameObject left;
    public GameObject right;
    public GameObject panelLR;
    public GameObject player;
    public GameObject particle;
    public GameObject tutorial;
    public SceneManager loadGame;
   
    

    public void Start()
    {
        if(PlayerPrefs.GetInt("firstime") != 1)
        {
            firstTime.SetActive(true);
            PlayerPrefs.SetInt("credits" , 100);

        }
        else
        {
            firstTime.SetActive(false);
        }
        canvas.SetActive(true);

    }
    public void Update()
    {
        if(PlayerPrefs.GetInt("firstime") == 0)
        {
            panelLR.SetActive(true);
        
        if(player.transform.position.x < -3)
        {
            left.SetActive(false);
        }
        if(player.transform.position.x > 3)
        {
            right.SetActive(false);
        }
        
        if(right.activeInHierarchy == false && left.activeInHierarchy == false)
        {

            PlayerPrefs.SetInt("runs" , -1);
            PlayerPrefs.SetInt("firstime" , 1);
            SceneManager.LoadScene("SampleScene");



        }
        }
        

    }




 
    
    public void EndGame()
    {
        Destroy(tutorial);
        canvas.SetActive(false);
        Invoke("endScreen" , .5f);
        
    }

    void endScreen()
    {

        Text txt = distance.GetComponent<Text>();
        txt.text = lastRun.text + "";
        deadUI.SetActive(true);
        Text txtHigh = highscore.GetComponent<Text>();
        int intHighScore = PlayerPrefs.GetInt("highscore");


        int intLastRun =  int.Parse(lastRun.text);
        PlayerPrefs.SetInt("runs" , PlayerPrefs.GetInt("runs") + 1);
        runs.text = PlayerPrefs.GetInt("runs") + "";

        PlayerPrefs.SetInt("total" , PlayerPrefs.GetInt("total") + int.Parse(lastRun.text));
        average.text = (PlayerPrefs.GetInt("total") / PlayerPrefs.GetInt("runs")) + "";


        PlayerPrefs.SetInt("credits" , PlayerPrefs.GetInt("credits") + (int)(intLastRun / 10));
        credits.text = PlayerPrefs.GetInt("credits") + "";





        if (intHighScore < intLastRun)
        {
            PlayerPrefs.SetInt("highscore" , intLastRun);
        }
          highscore.text = PlayerPrefs.GetInt("highscore") + "";



   
        




    }




}
