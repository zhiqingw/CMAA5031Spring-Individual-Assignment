using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement Speed

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }
}
