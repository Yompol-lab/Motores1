using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovE : MonoBehaviour
{
    public float velocidad = 3f;
    public float tiempoVivo = 0f;
    public float tiempoVidaMaximo = 3f;

  
    void Update()
    {
        transform.position -=new Vector3(velocidad*(Time.deltaTime), 0, 0);
        tiempoVivo += Time.deltaTime;


        if (tiempoVivo >= tiempoVidaMaximo)
        {
            Destroy(this.gameObject);

        }

       

    }
}
