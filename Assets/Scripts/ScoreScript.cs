using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
    }



    void UpdateScoreText()
    {
        scoreText.text = $"{GameManager.Instance.PlayerName} : Score: {GameManager.Instance.Score} ";
    }
}
