using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public float doorSpeed = 2f;
    private bool isOpening = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOpening == true)
        {
            if(transform.position.x < 4)
            {
                Vector3 move = transform.right * doorSpeed * Time.deltaTime;
                transform.Translate(move);
            }

        
        }
        else
        {
            if(transform.position.x > 0.1)
            {
                Vector3 move = transform.right * doorSpeed * -1 * Time.deltaTime;
                transform.Translate(move);
            }
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player przy drzwiach");
            isOpening = true;
      
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player daleko od drzwi");
            isOpening = false;
            
        }
    }


}
