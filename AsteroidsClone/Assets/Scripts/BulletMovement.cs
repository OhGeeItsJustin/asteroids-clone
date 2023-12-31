using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;

    // Add force to bullet
    void Start()
    {
        speed = 10f;
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * speed, ForceMode2D.Impulse);

        Destroy(gameObject, (float)0.8);
    }
}
