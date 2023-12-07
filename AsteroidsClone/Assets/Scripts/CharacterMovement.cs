using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float rotationSpeed = 160; // Degrees per second

    void Start()
    {
        
    }

    void Update()
    {
        // Depending on if right or left arrow keys are pressed change the rotation
        bool rotateCW = Input.GetKey(KeyCode.RightArrow);
        bool rotateCCW = Input.GetKey(KeyCode.LeftArrow);

        float angle = 0;

        if(rotateCW)
        {
            angle -= rotationSpeed;
        }
        if(rotateCCW)
        {
            angle += rotationSpeed;
        }

        float currentZ = transform.rotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(0, 0, currentZ + angle * Time.deltaTime);

    }
}
