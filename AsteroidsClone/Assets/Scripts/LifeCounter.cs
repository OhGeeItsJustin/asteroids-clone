using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LifeCounter : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    private int life = 3;

    // Function to add lives
    public void AddToLives()
    {
        if(life < 6) 
        {
            life++;
        }
        scoreDisplay.text = $"Lives: {life} ";
    }

    public int GetLives()
    {
        return life;
    }

    public void MinusLife()
    {
        life--;
        scoreDisplay.text = $"Lives: {life} ";
    }

    void Start()
    {
        scoreDisplay.text = $"Lives: {life} ";
    }
}
