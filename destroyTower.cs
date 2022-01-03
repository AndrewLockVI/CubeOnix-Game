using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTower : MonoBehaviour
{
   
public GameObject tower;
public GameObject player;
    void Update()
    {
        if(tower.transform.position.z < player.transform.position.z - 100)
        {
            Destroy(tower);
        }
    }
}
