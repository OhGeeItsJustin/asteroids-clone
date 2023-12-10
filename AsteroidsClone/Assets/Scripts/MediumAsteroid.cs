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

    // Give asteroid new rotation
    void Start()
    {
        float randomRotation = Random.Range(0, 360);
        float currentZ = transform.rotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(0, 0, currentZ + randomRotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If collision with bullet add points, destory bullet and split asteroid
        if (collision.gameObject.CompareTag("bullet"))
        {
            scoreCounter.AddToScore(pointsToAdd);
            SplitMediumAsteroid();
            Destroy(collision.gameObject);
        }

        // If collision with player add points, reset player position and split asteroid
        if (collision.gameObject.CompareTag("Player"))
        {
            character.CharacterReset();
            scoreCounter.AddToScore(pointsToAdd);
            SplitMediumAsteroid();
        }
    }

    // Create two new small asteroid and destory medium asteroid
    void SplitMediumAsteroid()
    {
        Vector3 position = transform.position;
        GameObject smallAsteroidOne = Instantiate(smallAsteroid, position, Quaternion.identity);
        GameObject smallAsteroidTwo = Instantiate(smallAsteroid, position, Quaternion.identity);
        smallAsteroidOne.SetActive(true);
        smallAsteroidTwo.SetActive(true);

        Destroy(gameObject);
    }
}
