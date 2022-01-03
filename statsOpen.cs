using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class statsOpen : MonoBehaviour
{
    
    public void openStats()
    {
        Invoke("statOpen" , .2f);

    }

    public void statOpen()
    {
        SceneManager.LoadScene("Stats");
    }
}
