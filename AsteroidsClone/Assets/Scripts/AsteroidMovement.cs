using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveBullet = new Vector3();
        moveBullet += transform.up * speed;
        transform.position += moveBullet * Time.deltaTime;
    }
}