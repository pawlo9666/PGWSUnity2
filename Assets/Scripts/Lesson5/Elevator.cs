using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 6.6f;
    private bool isRunningUp = true;
    private bool isRunningDown = false;
    private float downPosition;
    private float upPosition;
    private CharacterController CC;
    

    void Start()
    {
        upPosition = transform.position.z + distance;
        downPosition = transform.position.z;
        
    }

    void Update()
    {
        if (isRunningUp && transform.position.z >= upPosition)
        {
            isRunningUp = false;
            isRunningDown = true;
            elevatorSpeed = -2f;
            
        }
        else if (isRunningDown && transform.position.z <= downPosition)
        {
            isRunning = false;
            isRunningUp = true;
            isRunningDown = false;
            elevatorSpeed = 2f;

        }
        if (isRunning)
        {
            Vector3 move = transform.forward * elevatorSpeed * Time.deltaTime;
            transform.Translate(move);
            CC.Move(move);
          
        }
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszedł");
            isRunning = true;
            CC = other.GetComponent<CharacterController>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isRunning = false;
            Debug.Log("Player zszedł z windy.");
        }
    }
}