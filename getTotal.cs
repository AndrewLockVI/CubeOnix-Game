using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getTotal : MonoBehaviour
{
    public Text txtTotal;
    public Text txtHigh;
    public Text txtAverage;
    public Text txtRuns;
    public Text txtCredits;

    void Start()
    {
        txtTotal.text = PlayerPrefs.GetInt("total") + "";
        txtHigh.text = PlayerPrefs.GetInt("highscore") + "";
        txtAverage.text = (PlayerPrefs.GetInt("total") / PlayerPrefs.GetInt("runs")) + "";
        txtRuns.text = PlayerPrefs.GetInt("runs") + "";
        txtCredits.text = PlayerPrefs.GetInt("credits") + "";
        
    }


}
