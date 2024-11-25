using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverConPausa : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
        StartCoroutine(MoverObjeto());
    }

    IEnumerator MoverObjeto()
    {
       
        while (transform.position.x < 10f)
        {
            transform.position += Vector3.right * velocidad * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);

      
        while (transform.position.x > posicionInicial.x)
        {
            transform.position -= Vector3.right * velocidad * Time.deltaTime;
            yield return null;
        }
    }
}