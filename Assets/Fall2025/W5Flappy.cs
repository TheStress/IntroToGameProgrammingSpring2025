using UnityEngine;

public class W5Flappy : MonoBehaviour {
    public float jumpSpeed = 10; // Delcaring and setting a jumpSpeed
    public Rigidbody2D rb; // Declaring a rigidbody variable

    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody2D>(); // Getting the rigidbody on the current object and assign it to rb
    }

    // Update is called once per frame
    void Update() {
        if (isAlive) { // Checking if the player is alive
            if (Input.GetKeyDown(KeyCode.Space)) { // If the player presses space
                rb.linearVelocity = new Vector2(0, jumpSpeed); // Setting the velocity of the rigidbody to a vertical speed
            }
        }
    }

    public void Die() {
        isAlive = false; // Setting the boolean to false
    }
}
