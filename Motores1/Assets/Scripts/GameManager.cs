using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

   
    public Text coinsRemainingText;

   
    public GameObject victoryScreen;

    
    private int totalCoins;

    
    private int collectedCoins = 0;

    private void Awake()
    {
       
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

      
        victoryScreen.SetActive(false);
    }

    private void Start()
    {
     
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        UpdateUI();
    }

  
    public void CollectCoin()
    {
        collectedCoins++;
        UpdateUI();

      
        if (collectedCoins >= totalCoins)
        {
            ShowVictoryScreen();
        }
    }

    
    private void UpdateUI()
    {
        int coinsRemaining = totalCoins - collectedCoins;
        coinsRemainingText.text = "GB remaining: " + coinsRemaining;
    }

   
    private void ShowVictoryScreen()
    {
        victoryScreen.SetActive(true);
    }





}
