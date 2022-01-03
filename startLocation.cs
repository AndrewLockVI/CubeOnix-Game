using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startLocation : MonoBehaviour
{
    public GameObject cube;
    public GameObject revivebtn;
    public GameObject startAgain;
    public GameObject startToHide;
    void Start()
    {
        if(PlayerPrefs.GetInt("fromad") == 1)
        {
        Vector3 temp = cube.transform.position;
        temp.z = PlayerPrefs.GetInt("startLocation");
        cube.transform.position = temp;
        PlayerPrefs.SetInt("startLocation" , 0);
        PlayerPrefs.SetInt("fromad" , 0);
        PlayerPrefs.SetInt("LoadNum" , 1);
        Vector3 tempo = revivebtn.transform.position;
        tempo.x = 10000000;
        tempo.y = 10000000;
        revivebtn.transform.position = tempo;

        startAgain.SetActive(true);
        startToHide.SetActive(false);

        }
        else
        {
            PlayerPrefs.SetInt("startLocation" , 0);
        }

    }

   
}
