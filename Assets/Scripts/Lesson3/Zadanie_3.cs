using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zadanie_3 : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    public int flaga = 0;
    public float distancePerSecond;
    public int rotateSpeed;
 
    float x;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    

    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody>();

        if (rb.position.z <= 12 && flaga == 0)
        {
           
            if (rb.position.z >= 10)
            {
                if(transform.eulerAngles.y < 90)
                {
                    x += Time.deltaTime * rotateSpeed;
                    transform.rotation = Quaternion.Euler(0, x, 0);
                }
                else
                {
                    flaga = 1;
                }               
            }
            else
            {
               transform.Translate(0, 0, distancePerSecond* Time.deltaTime);
            }
                
        }
         
  
        if (rb.position.x < 12 && flaga == 1)
        {
            
            if (flaga == 1 && rb.position.x >= 10)
                if (transform.eulerAngles.y < 180)
                {
                    x += Time.deltaTime * rotateSpeed;
                    transform.rotation = Quaternion.Euler(0, x, 0);
                }
                else
                {
                    flaga = 2;
                }
            else
            {
                transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
            }
        }

                

        if (rb.position.z > -2 && flaga == 2)
        {
           
            if (flaga == 2 && rb.position.z <= 0)
                if (transform.eulerAngles.y < 270)
                {
                    x += Time.deltaTime * rotateSpeed;
                    transform.rotation = Quaternion.Euler(0, x, 0);
                }
                else
                {
                    flaga = 3;
                }    
            else
            {
                transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
            }
        }
                  

        if (rb.position.x > -2 && flaga == 3)
            
            if (flaga == 3 && rb.position.x <= 0)
            {
                if (!(transform.eulerAngles.y > 0 && transform.eulerAngles.y < 10))
                {
                    x += Time.deltaTime * rotateSpeed;
                    transform.rotation = Quaternion.Euler(0, x, 0);
                }
                else
                {
                    flaga = 0;
                }
            }
            else
            {
                transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
            }

    }
}
