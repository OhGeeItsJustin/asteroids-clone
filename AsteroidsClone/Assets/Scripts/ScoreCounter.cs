using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    private int score = 0;
    //public LifeCounter lifeCounter;

    public void AddToScore(int points)
    {
        score += points;
        scoreDisplay.text = $"Score: {score} ";

    }

    // If player score is divisible by 5000 add a live
    void Update()
    {
        if(score > 0)
        {
            if(score % 5000 == 0) 
            {
                //lifeCounter.AddToLives();
            }
        }
    }
}
