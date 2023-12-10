using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeAsteroid : MonoBehaviour
{

    void Start()
    {
        float x = Random.Range(-9f, 9f);
        float y = Random.Range(2f, 5f);
        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
