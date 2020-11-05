using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zadanie1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    public int numberOfObjects;
    // obiekt do generowania
    public GameObject block;
    public GameObject triangle;
    public GameObject obstacle;
    public GameObject plate;
    public GameObject ciasto;
    public List<GameObject> lista = new List<GameObject>();


    void Start()
    {
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(-9, 19).OrderBy(x => Guid.NewGuid()).Take(numberOfObjects));
        List<int> pozycje_z = new List<int>(Enumerable.Range(-9, 19).OrderBy(x => Guid.NewGuid()).Take(numberOfObjects));
       
        lista.Add(block);
        lista.Add(triangle);
        lista.Add(obstacle);
        lista.Add(plate);
        lista.Add(ciasto);

        for (int i = 0; i < numberOfObjects-1; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            int counter = UnityEngine.Random.Range(0,5);
            Instantiate(this.lista.ElementAt(counter), this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}