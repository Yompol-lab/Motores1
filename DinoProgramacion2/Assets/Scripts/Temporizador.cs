using System.Collections;
using UnityEngine;
using UnityEngine.UI; 

public class Temporizador : MonoBehaviour
{
    public int tiempoInicial = 10;
    public Text textoTemporizador; 

    void Start()
    {
        StartCoroutine(ContarRegresivamente());
    }

    IEnumerator ContarRegresivamente()
    {
        int tiempoRestante = tiempoInicial;

        while (tiempoRestante > 0)
        {
            Debug.Log(tiempoRestante);
            if (textoTemporizador != null)
                textoTemporizador.text = tiempoRestante.ToString();
                
            yield return new WaitForSeconds(1f);
            tiempoRestante--;
        }

        Debug.Log("¡Tiempo terminado!");
        if (textoTemporizador != null)
            textoTemporizador.text = "¡Tiempo terminado!";
    }
}
