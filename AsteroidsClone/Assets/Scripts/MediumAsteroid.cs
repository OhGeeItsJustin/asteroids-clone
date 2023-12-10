using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class MediumAsteroid : MonoBehaviour
{
    public GameObject smallAsteroid;
    public ScoreCounter scoreCounter;
    public CharacterMovement character;
    public int pointsToAdd = 50;
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
        if (collision.gameObject.CompareTag("bullet"))
        {
            scoreCounter.AddToScore(pointsToAdd);
            SplitMediumAsteroid();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            character.CharacterReset();
            scoreCounter.AddToScore(pointsToAdd);
            SplitMediumAsteroid();
        }
    }

    void SplitMediumAsteroid()
    {
        // Give bullet the players position
        Vector3 position = transform.position;
        GameObject smallAsteroidOne = Instantiate(smallAsteroid, position, Quaternion.identity);
        GameObject smallAsteroidTwo = Instantiate(smallAsteroid, position, Quaternion.identity);

        // Display to screen
        smallAsteroidOne.SetActive(true);
        smallAsteroidTwo.SetActive(true);

        Destroy(gameObject);
    }
}
