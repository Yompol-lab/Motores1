using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM : MonoBehaviour
{
    public GameObject obstaculo;
    public Vector2 spawnpos;
    public float delay = 2f;
    public float repeatRate = 2;




    void Start()
    {

        InvokeRepeating("SpawnObstacle", delay, repeatRate);


    }

   
    void SpawnObstacle()
    {
       
        Instantiate(obstaculo, spawnpos, obstaculo.transform.rotation);


    }
}
