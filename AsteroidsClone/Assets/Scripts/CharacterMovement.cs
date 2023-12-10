using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public LifeCounter lifeCounter;
    public float speed = 3f;
    public float rotationSpeed = 160; // Degrees per second

    void Start()
    {

    }

    void Update()
    {
        // Depending on if right or left arrow keys are pressed change the rotation
        bool doRotateCW = Input.GetKey(KeyCode.RightArrow);
        bool doRrotateCCW = Input.GetKey(KeyCode.LeftArrow);

        float angle = 0;

        if (doRotateCW)
        {
            angle -= rotationSpeed;
        }
        if (doRrotateCCW)
        {
            angle += rotationSpeed;
        }

        float currentZ = transform.rotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(0, 0, currentZ + angle * Time.deltaTime);

        // Move forward using relative upward-facing direction
        bool doMoveForward = Input.GetKey(KeyCode.UpArrow);

        Vector3 moveCharacter = new Vector3();

        if (doMoveForward)
        {
            moveCharacter += transform.up * speed;
        }

        transform.position += moveCharacter * Time.deltaTime;

    }

    public void CharacterReset()
    {
        lifeCounter.MinusLife();
        int lives = lifeCounter.GetLives();
        if(lives > 0)
        {
            transform.position = Vector3.zero;
        } else
        {
            Destroy(gameObject);
        }
    }
}
