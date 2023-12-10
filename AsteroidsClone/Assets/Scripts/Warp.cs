using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    // When objects collide set the colliding object to opposite side of screen 
    [field: SerializeField] public Vector3 Offset { get; set; }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        Vector3 newPosition = collider2D.transform.position + Offset;
        Debug.Log(collider2D.transform.position);
        Debug.Log(collider2D.transform.position + Offset);
        collider2D.attachedRigidbody.MovePosition(newPosition);
    }
}
