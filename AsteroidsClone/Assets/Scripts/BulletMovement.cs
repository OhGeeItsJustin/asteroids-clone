using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float maxDistance;
    public float currentDistance;
    public float speed;

    void Start()
    {
        maxDistance = 7;
        currentDistance = 0;
        speed = 10f;
    }

    void Update()
    {
        // Move forward using relative upward-facing direction
        Vector3 moveBullet = new Vector3();
        moveBullet += transform.up * speed;
        transform.position += moveBullet * Time.deltaTime;

        // Track distance bullet has moved and delete bullet object after hitting max distance
        currentDistance += speed * Time.deltaTime;
        if (currentDistance > maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
