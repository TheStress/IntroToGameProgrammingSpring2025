using UnityEngine;

public class ForceBasedMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float force = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        Vector2 movementForce = new Vector2(0, 0); // Declaring the variable

        if (Input.GetKey(KeyCode.W)) { // Checking W input
            movementForce = new Vector2(0, 1) * force;  // Calculating the force added to move up
            rb.AddForce(movementForce); // Setting velocity
        }
        if (Input.GetKey(KeyCode.A)) { // Checking A input
            movementForce = new Vector2(-1, 0) * force; // Calculating the force added to move left
            rb.AddForce(movementForce); // Setting velocity
        }
        if (Input.GetKey(KeyCode.S)) { // Checking S input
            movementForce = new Vector2(0, -1) * force; // Calculating the force added to move down
            rb.AddForce(movementForce); // Setting velocity
        }
        if (Input.GetKey(KeyCode.D)) { // Checking D input
            movementForce = new Vector2(1, 0) * force; // Calculating the force added to move right
            rb.AddForce(movementForce); // Setting velocity
        }
    }

    //void Update() {
    //    Vector2 movementForce = new Vector2(0, 0); // Declaring the variable

    //    if (Input.GetKey(KeyCode.W)) { // Checking W input
    //        movementForce = new Vector2(0, 1) * force;  // Calculating the force added to move up
    //        rb.AddForce(movementForce); // Applying the force
    //    }
    //    if (Input.GetKey(KeyCode.A)) { // Checking A input
    //        movementForce = new Vector2(-1, 0) * force; // Calculating the force added to move left
    //        rb.AddForce(movementForce); // Applying the force
    //    }
    //    if (Input.GetKey(KeyCode.S)) { // Checking S input
    //        movementForce = new Vector2(0, -1) * force; // Calculating the force added to move down
    //        rb.AddForce(movementForce); // Applying the force
    //    }
    //    if (Input.GetKey(KeyCode.D)) { // Checking D input
    //        movementForce = new Vector2(1, 0) * force; // Calculating the force added to move right
    //        rb.AddForce(movementForce); // Applying the force
    //    }
    //}
}
