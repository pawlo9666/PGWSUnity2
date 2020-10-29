using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_4 : MonoBehaviour
{

    public float speed = 2.0f;
    Rigidbody rb;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            Debug.Log("Pyk");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        // tworzymy wektor prędkości
        Vector3 velocity = new Vector3(mH, 0, mV);
        velocity = velocity.normalized * speed * Time.deltaTime;
        // wykonujemy przesunięcie Rigidbody z uwzględnieniem sił fizycznych
        rb.MovePosition(transform.position + velocity);
    }
}
