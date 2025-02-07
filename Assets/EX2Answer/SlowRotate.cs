using UnityEngine;

public class SlowRotate : MonoBehaviour
{
    public float rotateSpeed = 0.1f;
    float currentRot = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRot += rotateSpeed;
        transform.rotation = Quaternion.Euler(0, 0, currentRot);
    }
}
