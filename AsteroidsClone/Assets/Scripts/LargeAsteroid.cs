using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeAsteroid : MonoBehaviour
{
    public GameObject mediumAsteroid;
    public ScoreCounter scoreCounter;
    public CharacterMovement character;
    public int pointsToAdd = 20;
    void Start()
    {
        float x = Random.Range(-9f, 9f);
        float y = Random.Range(2f, 5f);
        transform.position = new Vector3(x, y, 0);
        float randomRotation = Random.Range(0, 360);

        // Give bullet the players rotation
        float currentZ = transform.rotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(0, 0, currentZ + randomRotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("bullet") )
        {
            scoreCounter.AddToScore(pointsToAdd);
            SplitLargeAsteroid();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            character.CharacterReset();
            scoreCounter.AddToScore(pointsToAdd);
            SplitLargeAsteroid();
        }
    }

    void SplitLargeAsteroid()
    {
        // Give bullet the players position
        Vector3 position = transform.position;
        GameObject mediumAsteroidOne = Instantiate(mediumAsteroid, position, Quaternion.identity);
        GameObject mediumAsteroidTwo = Instantiate(mediumAsteroid, position, Quaternion.identity);

        // Display to screen
        mediumAsteroidOne.SetActive(true);
        mediumAsteroidTwo.SetActive(true);

        Destroy(gameObject);
    }
}
