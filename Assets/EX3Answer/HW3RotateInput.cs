using UnityEngine;

public class HW3RotateInput : MonoBehaviour {
    public float rotateSpeed = 0.1f;
    float currentZValue = 0;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            currentZValue += rotateSpeed;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            currentZValue -= rotateSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, currentZValue);
    }
}