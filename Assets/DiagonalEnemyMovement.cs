using UnityEngine;

public class DiagonalEnemyMovement : MonoBehaviour
{
    public float speed = 5f; // The speed at which the enemy moves
    public float diagonalDuration = 2f; // The duration of each diagonal movement

    private Vector3 direction; // The direction the enemy is moving in
    private float timer; // Timer to track the duration

    private void Start()
    {
        // Set the initial direction of the enemy
        direction = new Vector3(1f, -1f, 0f).normalized; // Move diagonally to the bottom-right initially
        timer = 0f;
    }

    void Update()
    {
        // Move the enemy
        transform.Translate(direction * speed * Time.deltaTime);

        // Update the timer
        timer += Time.deltaTime;

        // Check if the diagonal duration has passed
        if (timer >= diagonalDuration)
        {
            // Reverse the direction
            direction *= -1f;

            // Reset the timer
            timer = 0f;
        }
    }
}
