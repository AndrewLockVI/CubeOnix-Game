using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{


    

// Score modifier - edit text object to modify
    public float scoreMod;

// This is the cube being tracked in position for z axis    
    public Transform cubeTrans;


//Function used to update text as the object moves away from 0 on the z axis
    void Update()
    {
        float intScore = cubeTrans.position.z;
        Text txt = gameObject.GetComponent<Text>();
        txt.text = (int)(intScore * scoreMod) + "";

    }
}
