using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAppearManagement : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float appearTimeInterval = 2f;
    public Transform appearPoint;

    private float timeCount = 0;
    private GameObject newEnemy;

    // Update is called once per frame
    void Update()
    {
        // Counting Time
        timeCount += Time.deltaTime;

        // Init enemy object
        if (timeCount > appearTimeInterval)
        {
            timeCount = 0; // Reset timeCount
            newEnemy = Instantiate(enemyPrefab, appearPoint); // Creat an enemy at the position of the appearPoint
            // Set and Radomized appear loction
            newEnemy.transform.position = appearPoint.position;
            newEnemy.transform.Translate(newEnemy.transform.right * Random.Range(-1.0f, 1.0f) * 10);
        }
    }
}
