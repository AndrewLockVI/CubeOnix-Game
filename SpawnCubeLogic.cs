using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
           public Rigidbody rb = new Rigidbody();
           public float start = 0;
           public GameObject cube;
           public Vector3 startPos;
           public float bounds = 2.5f;

           

   
    void Start()
    {
        rb.useGravity = false;
        start = transform.position.y;
        startPos = transform.position;
        startMove(100);

       
        
    }

   




    void Update()
    {
          

            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.useGravity = true;
                Vector3 vel0 = rb.velocity;
                vel0.x = 0;
                vel0.y = 0;
                vel0.z = 0;
                rb.velocity = vel0;
                
            }
      
    if ( transform.position.y == start ) 
    {
        randomeMove();

    }
     

        
    }

    void randomeMove()
    {

      if (transform.position.x >= bounds )
        {
           
            Vector3 Vel = rb.velocity;
            Vel.x = Mathf.Abs (Vel.x) * -1 ;
            rb.velocity = Vel;

        }
        else if (transform.position.x <= -bounds )
        {
            Vector3 Vel = rb.velocity;
            Vel.x = Mathf.Abs (Vel.x) * 1 ;
            rb.velocity = Vel;

        }

        else if (transform.position.z >= bounds )
        {
            Vector3 Vel = rb.velocity;
            Vel.z = Mathf.Abs (Vel.z) * -1 ;
            rb.velocity = Vel;

        }

        else if (transform.position.z <= -bounds )
        {
            Vector3 Vel = rb.velocity;
            Vel.z = Mathf.Abs (Vel.z) * 1 ;
            rb.velocity = Vel;

        }

        else 
        {


        

        
    }
    }
     void startMove(float cubeMulti)
    {

        float rnd = (float)Random.value;
        float plusorMin = Random.value;

        
        if (plusorMin > .5)
        {
            rnd = (1 + rnd) * -1;
        }
        else
        {
            rnd += 1;
        }



        float rnd1 = (float)Random.value ;
        float plusorMin1 = Random.value;

        
        if (plusorMin1 > .5)
        {
            rnd1 =  (1 + rnd1) * -1;
        }
        else
         {
                rnd1 += 1;
         }
        
        rb.AddForce(transform.forward * rnd1 * cubeMulti);
        rb.AddForce(transform.right * rnd * cubeMulti);




    }


    

  

}


