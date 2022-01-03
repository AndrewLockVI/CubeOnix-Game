using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject particle;
    public GameObject cube;
    public GameObject tutorial;


        void Update()
        {
            if (cube.transform.position.y < -20)
            {
                particle.SetActive(true);
                particle.transform.position = cube.transform.position;
                cube.SetActive(false);
                gameManager.EndGame();
            }
        }

        void OnCollisionEnter(Collision col)
        {

        
            if(col.gameObject.tag == "obstacle")
            {
                particle.SetActive(false);
                particle.SetActive(true);
                particle.transform.position = cube.transform.position;
                int obstacle =(int) ((cube.transform.position.z) / 150);
                PlayerPrefs.SetInt("startLocation" , ((int)cube.transform.position.z));
                cube.SetActive(false);
                tutorial.SetActive(false);
                gameManager.EndGame();
                
            }

        }



}
