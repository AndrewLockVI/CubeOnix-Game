using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject player;

    void Update()
    {


        
        if(obstacle.transform.position.z < player.transform.position.z - 300)
        {
            Object.Destroy(obstacle);

        }
    }
}
