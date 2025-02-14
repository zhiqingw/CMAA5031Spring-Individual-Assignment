using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletsCollection;
    public float shotTimeInterval = 0.8f;

    private float timeCount = 0;
    private GameObject newBullet;

    // Update is called once per frame
    void Update()
    {
        // Counting Time
        timeCount += Time.deltaTime;

        // Shot if time enough
        if (timeCount > shotTimeInterval)
        { 
            timeCount = 0;
            newBullet = Instantiate(bulletPrefab, bulletsCollection.transform);
            newBullet.transform.position = new Vector3(this.transform.position.x, 1.8f, this.transform.position.z);
        }
    }
}
