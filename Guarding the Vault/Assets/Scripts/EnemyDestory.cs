using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestory : MonoBehaviour
{
    void Update()
    {
        // Destory itself when the Pos.Z value is lower than -15 (Disappear from the camera view)
        if (this.transform.position.z < -15.0f)
            DestorySelf(this.gameObject);
    }

    public static void DestorySelf(GameObject obj)
    {
        Destroy(obj); // Destory the object itself
    }
}
