using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SmallAsteroid : MonoBehaviour
{
    public GameObject aLargeAsteroid;
    public ScoreCounter scoreCounter;
    public CharacterMovement character;
    public int pointsToAdd = 100;

    // Give asteroid new rotation
    void Start()
    {
        float randomRotation = Random.Range(0, 360);
        float currentZ = transform.rotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(0, 0, currentZ + randomRotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If collision with bullet add points, destory bullet and create new large asteroid
        if (collision.gameObject.CompareTag("bullet"))
        {
            scoreCounter.AddToScore(pointsToAdd);
            SplitSmallAsteroid();
            Destroy(collision.gameObject);
        }

        // If collision with player add points, reset player position and create new large asteroid
        if (collision.gameObject.CompareTag("Player"))
        {
            character.CharacterReset();
            scoreCounter.AddToScore(pointsToAdd);
            SplitSmallAsteroid();
        }
    }

    // Create new large asteroid and destory small asteroid
    void SplitSmallAsteroid()
    {
        Vector3 position = transform.position;
        GameObject largeAsteroid = Instantiate(aLargeAsteroid, position, Quaternion.identity);
        largeAsteroid.SetActive(largeAsteroid);
        Destroy(gameObject);
    }
}
