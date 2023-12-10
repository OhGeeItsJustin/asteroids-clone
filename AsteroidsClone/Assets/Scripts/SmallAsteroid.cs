using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallAsteroid : MonoBehaviour
{
    public GameObject aLargeAsteroid;
    public ScoreCounter scoreCounter;
    public int pointsToAdd = 100;
    // Start is called before the first frame update
    void Start()
    {
        float randomRotation = Random.Range(0, 360);

        // Give bullet the players rotation
        float currentZ = transform.rotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(0, 0, currentZ + randomRotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("asteroid"))
        {
            scoreCounter.AddToScore(pointsToAdd);
            SplitSmallAsteroid();
            Destroy(collision.gameObject);
        }
    }

    void SplitSmallAsteroid()
    {
        // Give bullet the players position
        Vector3 position = transform.position;
        GameObject largeAsteroid = Instantiate(aLargeAsteroid, position, Quaternion.identity);

        Destroy(gameObject);
    }
}
