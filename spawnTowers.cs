using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTowers : MonoBehaviour
{
    public GameObject towers;
    public GameObject player;
    private float obstacleNum = 0;
    
    
    void Update()
    {
        if(player.transform.position.z > (obstacleNum - 30)* 35)
        {
            spawntower(obstacleNum * 35);
            obstacleNum += 1;
        }

        
    }

    void spawntower(float z)
    {
        Quaternion zero = player.transform.rotation;
        zero.x = 0;
        zero.y = 0;
        zero.z = 0;
        Vector3 spawnLocation = player.transform.position;
        spawnLocation.y = Random.Range(-70 , 5);
        spawnLocation.x = Random.Range(-10 , 10);
        spawnLocation.z = z;

        Instantiate(towers , spawnLocation , zero);

    }
}
