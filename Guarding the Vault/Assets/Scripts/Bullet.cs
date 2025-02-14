using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damageValue = 12.0f;
    public float moveSpeed = 20.0f;
    public float destoryTime = 5.0f;

    private float timeCount = 0;

    // Update is called once per frame
    void Update()
    {
        // Counting Time
        timeCount += Time.deltaTime;

        // Bullet movement
        this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // If bullet exist too long, detory it to reduce the performace demand
        if (timeCount > destoryTime)
            DestorySelf();
    }

    // Destory the bullet itself
    void DestorySelf()
    {
        Destroy(this.gameObject);
    }

    // If hit a collider
    void OnTriggerEnter(Collider other)
    {
        EnemyHealthManagement enemyHealth = other.transform.gameObject.GetComponent<EnemyHealthManagement>(); // Get the health component of the enemy
        if (enemyHealth != null) // If the component is exist
        {
            enemyHealth.GetHit(damageValue); // Hit the enemy
        }
    }
}
