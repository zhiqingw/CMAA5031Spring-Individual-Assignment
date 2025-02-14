using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement Speed

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Will be true when Button A being pressed
        {
            if (this.transform.position.x - moveSpeed * Time.deltaTime >= -15.0f) // Limit the movement space
                this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); // Move Left
        }

        if (Input.GetKey(KeyCode.D)) // Will be true when Button D being pressed
        {
            if (this.transform.position.x + moveSpeed * Time.deltaTime <= 15.0f) // Limit the movement space
                this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime); // Move Right
        }
    }
}