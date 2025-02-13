using UnityEngine;

public class HW3ScaleInput : MonoBehaviour {
    public float scaleSpeed = 0.1f;
    float currentXValue = 1;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            currentXValue += scaleSpeed;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            currentXValue -= scaleSpeed;
        }

        // Limit the scaling so it doesnt get inverted
        if(currentXValue < 0) {
            currentXValue = 0;
        }

        transform.localScale = new Vector3(currentXValue, 1, 1);
    }
}
