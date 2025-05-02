using UnityEngine;

public class W12LookAt : MonoBehaviour
{
    float targetAngle = 0;
    float currentAngle = 0;
    public float mag = 0.4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 dirToMouse = mousePos - transform.position;

        targetAngle = Mathf.Atan2(dirToMouse.y, dirToMouse.x) * Mathf.Rad2Deg;
        currentAngle = Mathf.Lerp(currentAngle, targetAngle, mag);

        transform.rotation = Quaternion.Euler(0, 0, currentAngle);
    }
}
