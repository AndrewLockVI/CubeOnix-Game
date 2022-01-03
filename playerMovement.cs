using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sideVel;
    public float velInit;
    public float slowDownRate;
    public float sideForce;
    public float multi;



    void Start()
    {
        Vector3 vel = rb.velocity;
        vel.z = velInit * Time.deltaTime ;
        rb.velocity = (vel);
        Vector3 gravity1 = Physics.gravity;
        gravity1.y = -40 * multi;
        Physics.gravity = gravity1; 
    }

    void Update()
    {
        if(multi < 1.5)
        {
        multi = 1 + (rb.position.z / 6000);
        }
        else
        {
            multi = 1.5f;
        }
        
        Vector3 startVel = rb.velocity;
        Vector3 sideVelocity = rb.velocity;
        startVel.z = velInit * multi;
       





        if(PlayerPrefs.GetInt("firstime") == 1)
        {
        rb.velocity = startVel;
        }
        

        float input = 0;


        if(Input.touchCount == 1)
        {
            var touch = Input.touches[0];

            if(touch.position.x < Screen.width / 2)
            {
                input = -1;
            }
            else
            {
                input = 1;
            }

        }
        else
        {
            input = Input.GetAxis("Horizontal");
        }

        
         
        
        if (input > 0)
        {
            if(sideVel < sideVelocity.x)
            {
            sideVelocity = rb.velocity;
            sideVelocity.x = sideVel * Time.deltaTime * 60 * multi;
            rb.velocity = sideVelocity;
            }
            else
            {
                rb.AddForce(sideForce * Time.deltaTime * 10, 0 , 0);
            }
        }
        else if (input < 0)
        {
            if(-sideVel > sideVelocity.x)
            {
                sideVelocity = rb.velocity;
                sideVelocity.x = -sideVel * Time.deltaTime * 60 * multi;
                rb.velocity = sideVelocity;
            }
            else
            {
                rb.AddForce(-sideForce * Time.deltaTime * 10 , 0 , 0);
            }

        }
        else if(rb.velocity.x < 5 & rb.velocity.x > -5)
        {
            sideVelocity = rb.velocity;
            sideVelocity.x = 0;
            rb.velocity = sideVelocity;
        }
        
        if(rb.velocity.x > 1 && input == 0)
        {
            rb.AddForce(-slowDownRate * Time.deltaTime * 5 , 0 , 0 );
        }
        else if(rb.velocity.x < -1 && input == 0)
        {
            rb.AddForce(slowDownRate * Time.deltaTime * 5 , 0 , 0 );
        }

    





       Quaternion rotation0 = rb.rotation;
        rotation0.y = 0;
        rotation0.z = 0;
        rb.rotation = rotation0;



        


    }
}
