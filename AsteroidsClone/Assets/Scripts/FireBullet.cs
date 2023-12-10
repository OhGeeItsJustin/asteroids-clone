using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{

    public GameObject bullet;

    void Update()
    {
        // If space bar is pressed create bullet gameobject
        bool doFireBullet = Input.GetKeyDown(KeyCode.Space);

        if (doFireBullet)
        {
            // Give bullet the players position
            Vector3 position = transform.position + transform.up;
            GameObject gobj = Instantiate(bullet, position, Quaternion.identity);

            // Give bullet the players rotation
            float currentZ = transform.rotation.eulerAngles.z;
            gobj.transform.rotation = Quaternion.Euler(0, 0, currentZ);

            // Display to screen
            gobj.SetActive(true);
        }
    }
}