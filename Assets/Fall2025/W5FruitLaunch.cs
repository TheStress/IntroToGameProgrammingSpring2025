using UnityEngine;

public class W5FruitLaunch : MonoBehaviour {

    public float launchForce = 500; // Delcaring and setting a launchSpeed
    public float rotationForce = 100; // Declaring and setting rotationForce
    public Vector3 direction = new Vector3(0, 0, 0);
    public Rigidbody2D rb; // Declaring a rigidbody variable
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = GetComponent<Rigidbody2D>(); // Getting the rigidbody on the current object and assign it to rb
        rb.AddForce(direction.normalized * launchForce); // Adding force to launch the fruit
        rb.AddTorque(rotationForce); // Adding force to rotate fruit
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
