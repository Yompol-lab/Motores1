using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFallReset : MonoBehaviour
{
    public float fallThreshold = -10f;

    void Update()
    {
      
        if (transform.position.y < fallThreshold)
        {
            Die();
        }
    }

    void Die()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




}
