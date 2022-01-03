using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacles : MonoBehaviour
{
    public GameObject simple1;
    public GameObject easy1;
    public GameObject easy2;
    public GameObject easy3;
    public GameObject easy4;
    public GameObject easy5;
    public GameObject easy6;
    public GameObject easy7;
    public GameObject easy8;
    public GameObject easy9;
    public GameObject easy10;
    public GameObject medium1;
    public GameObject hard1;
    public GameObject hard2;
    public GameObject hard3;
    public GameObject hard4;
    public GameObject hard5;
    public GameObject hard6;
    public GameObject hard7;
    public GameObject hard8;
    public Transform allZero;
    public GameObject cube;
    public int spawnNext = 0;
    public int obstaclecount = 0;
    private float StartVal;


   void Start()
   {
       StartVal = PlayerPrefs.GetInt("startLocation");
       simple1.SetActive(true);
       easy1.SetActive(true);
        easy2.SetActive(true);
        easy3.SetActive(true);
        easy4.SetActive(true);
        easy5.SetActive(true);
        easy6.SetActive(true);
        easy7.SetActive(true);
        easy8.SetActive(true);
        easy9.SetActive(true);
        easy10.SetActive(true);
        hard8.SetActive(true);
        medium1.SetActive(true);
        hard1.SetActive(true);
        hard2.SetActive(true);
        hard3.SetActive(true);
        hard4.SetActive(true);
        hard5.SetActive(true);
        hard6.SetActive(true);
        hard7.SetActive(true);
       
        
   } 

    void Update()
    {
     
         
         if(cube.transform.position.z > ((obstaclecount - 4) * 150) + 50)
          {
            Spawnhelp(obstaclecount);
            obstaclecount += 1;
          }
       
        
    }

    void Spawnhelp(int obstacleNum)
    {
        Vector3 spawnLocal = allZero.position;
        spawnLocal.z = StartVal + 50 + (obstacleNum * 150);
        allZero.position = spawnLocal;
        Spawn(allZero , spawnLocal);
       
    }







    void Spawn(Transform transPOS,Vector3 location)
    {
        Quaternion rotation = cube.transform.rotation;
        rotation.x = 0;
        rotation.y = 0;
        rotation.z = 0;


        if(transPOS.position.z < 1000)
        {
        double rnd = Random.Range(0 , 13);
        if(rnd < 1)
        {
            Instantiate(easy1 , location , rotation);
            
        }
        else if(rnd < 2)
        {
            Instantiate(easy2 , location , rotation);
        }
        else if(rnd < 3)
        {
            Instantiate(easy3 , location , rotation);
        }
        else if(rnd < 4)
        {
            Instantiate(easy4 , location , rotation);
        }
        else if(rnd < 5)
        {
            Instantiate(easy5 , location , rotation);
        }
        else if(rnd < 6)
        {
            Instantiate(easy6 , location , rotation);
        }
        else if(rnd < 7)
        {
            Instantiate(medium1 , location , rotation);
        }
        else if(rnd < 8)
        {
            Instantiate(simple1 , location , rotation);
        }
        else if(rnd < 9)
        {
            Instantiate(easy8 , location , rotation);
        }
        else if(rnd < 10)
        {
            Instantiate(easy7 , location , rotation);
        }
        else if(rnd < 11)
        {
            Instantiate(easy9 , location, rotation);
        }
        else if(rnd < 12)
        {
            Instantiate(easy10 , location, rotation);
        }
        else
        {
            Spawn(transPOS , location);
        }
        }
        else
        {
        double rnd = Random.Range(7 , 16);
        if(rnd < 8)
        {
            Instantiate(hard1 , location , rotation);
        }
        else if(rnd < 9)
        {
            Instantiate(hard2 , location , rotation);
        }
        else if(rnd < 10)
        {
            Instantiate(hard3 , location, rotation);
        }
        else if(rnd < 11)
        {
            Instantiate(hard4 , location , rotation);
        }
        else if(rnd < 12)
        {
            Instantiate(hard5 , location , rotation);
        }
        else if(rnd < 13)
        {
            Instantiate(hard6 , location , rotation);
        }
        else if(rnd < 14)
        {
            Instantiate(hard7 , location , rotation);
        }
        else if(rnd < 15)
        {
            Instantiate(hard8 , location , rotation);
        }
        else
        {
            Spawn(transPOS , location);
        }
        }
        

    }

  

}
