using UnityEngine;

public class HW3ARotatingSword : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    public float currentRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        currentRotation += rotationSpeed;
        transform.rotation = Quaternion.Euler(0, 0, currentRotation);
    }
}
