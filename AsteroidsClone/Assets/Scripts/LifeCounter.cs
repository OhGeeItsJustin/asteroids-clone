using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    private int life = 3;

    public void AddToLives()
    {
        if(life > 6) 
        {
            life++;
        }
    }
}
