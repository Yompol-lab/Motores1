using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject obstaculo;
    public Vector2 spawnPos;
    public float delay = 2f;
    public float repeatRate = 2;




    void Start()
    {
        InvokeRepeating("SpawnObstacle", delay, repeatRate);
    }

    
    void SpawnObstacle()
    {
        Instantiate(obstaculo, spawnPos, obstaculo.transform.rotation);
    }
}
