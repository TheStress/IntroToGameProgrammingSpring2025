using UnityEngine;

public class EX3RotateInput : MonoBehaviour
{
    public float rotateSpeed = 0.1f;
    public bool reverseDirection = false;
    float currentZValue = 0;

    // Update is called once per frame
    void Update()
    {
        if (reverseDirection) {
            currentZValue += rotateSpeed;
        }
        else {
            currentZValue -= rotateSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, currentZValue);
    }
}