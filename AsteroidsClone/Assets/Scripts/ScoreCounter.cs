using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int score;

    public void AddToScore(int points)
    {
        score += points;
    }
}
