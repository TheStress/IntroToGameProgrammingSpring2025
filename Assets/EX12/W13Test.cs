using UnityEngine;

public class W13Test : MonoBehaviour
{
    Vector3 targetPosition;
    float percent = 0.5f;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, percent*Time.deltaTime);
    }
}

