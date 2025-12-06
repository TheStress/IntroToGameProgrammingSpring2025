using UnityEngine;

public class W4MouseTesting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        float mouseXDifference = Input.GetAxis("Mouse X"); // Gets the movement of the mouse on the x axis
        float mouseYDifference = Input.GetAxis("Mouse Y"); // Gets the movement of the mouse on the y axis
        transform.position = new Vector3(mouseXDifference, mouseYDifference, 0); // Sets the position of this object to visualize mouse movement
    }
}
