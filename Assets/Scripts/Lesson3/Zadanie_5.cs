using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Zadanie_5 : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    int counter = 0;
    public float CollisionCheck;


    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        while(counter != 10)
        {
            Vector3 Spawn = new Vector3(Random.Range(-4.5f, 4.5f), 0, Random.Range(-4.5f, 4.5f));
            if(!(Physics.CheckSphere(Spawn , CollisionCheck)))
            {
                Instantiate(myPrefab, Spawn, Quaternion.identity);
                counter++;
                
            }
          

        }
        
        
    }
}
