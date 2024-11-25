using UnityEngine;
using System.Collections;

public class CambiarTamano : MonoBehaviour
{
    public Vector3 minTamano = new Vector3(0.5f, 0.5f, 0.5f);
    public Vector3 maxTamano = new Vector3(2f, 2f, 2f);

    void Start()
    {
        StartCoroutine(CambiarTamanoCadaSegundo());
    }

    IEnumerator CambiarTamanoCadaSegundo()
    {
        while (true)
        {
            Vector3 nuevoTamano = new Vector3(
                Random.Range(minTamano.x, maxTamano.x),
                Random.Range(minTamano.y, maxTamano.y),
                Random.Range(minTamano.z, maxTamano.z)
            );

            transform.localScale = nuevoTamano;
            yield return new WaitForSeconds(1f);
        }
    }
}
