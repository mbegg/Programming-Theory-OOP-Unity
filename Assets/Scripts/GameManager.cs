using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    private int score;
    private string playerName;

    public static GameManager Instance { get; private set; }
    public int Score { get => score; set => score = value; }
    public string PlayerName { get => playerName; set => playerName = value; }

    public void Awake()
    {
        if(Instance !=  null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this; 
        DontDestroyOnLoad(gameObject);


    }
    public void IncreaseScore(int amount)
    {
        Score += amount;
    }

}
