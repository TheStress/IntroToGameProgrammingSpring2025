using UnityEngine;

public class W13LookAt : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // finding mouse position

        Vector3 dirToMouse = mousePos - transform.position; // finding direction to mouse

        float currentAngle = Mathf.Atan2(dirToMouse.y, dirToMouse.x) * Mathf.Rad2Deg; // getting angle using trig

        transform.rotation = Quaternion.Euler(0, 0, currentAngle); // setting the rotation
    }
}
