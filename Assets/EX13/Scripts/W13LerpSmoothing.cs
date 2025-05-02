using UnityEngine;

public class W13LerpSmoothing : MonoBehaviour
{
    public Vector3 targetPosition; // the position this object is moving towards
    public float percent; // the percent traveled each update, a percent always needs to be between [0.0, 1.0]

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, percent);
    }
}