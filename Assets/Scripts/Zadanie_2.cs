using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_2 : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    int flaga = 0;
    public float distancePerSecond;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    

    void Update()
    {
        rb = GetComponent<Rigidbody>();
        if (rb.position.z < 10 && flaga == 0)
            transform.Translate(0, 0, distancePerSecond * Time.deltaTime);
        else
        {
            flaga = 1;
            transform.Translate(0, 0, 0 - distancePerSecond * Time.deltaTime);
            if (rb.position.z < 0)
                flaga = 0;
        }
          

    }
}
