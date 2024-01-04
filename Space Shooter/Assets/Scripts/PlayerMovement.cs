using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Speed of player movement
    public float speed = 5f;

    void Update()
    {
        // Capture horizontal and vertical movement inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * speed * Time.deltaTime;

        // Move the player's ship
        transform.Translate(movement);

        // Limit the player's position to prevent going off-screen
        float xClamp = Mathf.Clamp(transform.position.x, -xLimit, xLimit);
        float yClamp = Mathf.Clamp(transform.position.y, -yLimit, yLimit);
        transform.position = new Vector3(xClamp, yClamp, transform.position.z);
    }

    // Set screen limits
    float xLimit = 8.5f;
    float yLimit = 4.6f;
}
