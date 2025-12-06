using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed; // How much we increase the current value
    public float magnitude; // The scale of how far the occilation is going
    public float currentValue; // The current value that is being converted to an offset
    public Vector3 center; // The center the object is rotating around

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        center = transform.position; // Setting center
    }

    // Update is called once per frame
    void Update() {
        currentValue += speed * Time.deltaTime; // Increasing value over time

        // Updating position based on all the values
        transform.position = center + new Vector3(magnitude*Mathf.Sin(currentValue), magnitude * Mathf.Cos(currentValue), 0);
    }
}


