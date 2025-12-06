using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float movementSpeed = 0.05f; // Declared and set movement speed
    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(-1, 0, 0) * movementSpeed; 
    }
}


