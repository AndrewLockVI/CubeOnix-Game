using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCube : MonoBehaviour
{
    public GameObject cube;
    public Vector3 startPos;
    public Text text;
    public int cubeNum = 0;
    private float tapTimeThreshold = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        spawnCube();
        text.text = "1";
    }


    private void spawnCube()
    {
    
         GameObject a = Instantiate(cube) as GameObject;
        
        a.transform.position = startPos;

        cubeNum += 1;
        text.text = cubeNum.ToString();


    }

    // Update is called once per frame
    void Update()
    {
            


             if(Input.GetKeyDown(KeyCode.Space) )
            {
                Invoke("spawnCube" , 1);

                
            }
    }
}
