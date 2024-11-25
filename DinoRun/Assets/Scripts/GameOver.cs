using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{

    public GameObject gameOverPanel;

    public void MostrarGameOver()
    {
        
        gameOverPanel.SetActive(true);



    }

    public void ReiniciarNIvel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }

}
