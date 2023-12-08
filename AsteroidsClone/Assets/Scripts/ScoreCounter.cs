using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;

    public void AddToScore(int points)
    {
        score += points;
    }
}
