using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadMan : MonoBehaviour
{
    void Start()
    {
        Invoke("loadin" , 2);
    }
    void loadin()
    {
        SceneManager.LoadScene("MainMenu");
    }

   
}
