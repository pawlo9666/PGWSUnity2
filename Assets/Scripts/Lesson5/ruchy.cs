using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruchy : MonoBehaviour
{
    public float Speed = 2f;
    public Vector3[] dobry;
    private int counter = 0;
    private bool flaga = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position == dobry[counter])
        {
            if(dobry.Length-1 > counter && flaga)
            {
                counter++;
            }
            else
            {
                flaga = false;
            }

            if (counter != 0 && !flaga)
            {
                counter--;
            }
            else
            {
                flaga = true;
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, dobry[counter], Speed * Time.deltaTime);


    }
}
