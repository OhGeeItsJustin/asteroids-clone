using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        speed = 10f;
    }

    void Update()
    {
        // Move forward using relative upward-facing direction
        Vector3 moveBullet = new Vector3();
        moveBullet += transform.up * speed;
        transform.position += moveBullet * Time.deltaTime;
    }
}
