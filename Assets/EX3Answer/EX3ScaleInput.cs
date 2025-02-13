using UnityEngine;

public class EX3ScaleInput : MonoBehaviour {
    public float scaleSpeed = 0.1f;
    public bool reverseDirection = false;
    float currentXValue = 1;

    // Update is called once per frame
    void Update() {
        if (reverseDirection) {
            currentXValue -= scaleSpeed;
        }
        else {
            currentXValue += scaleSpeed;
        }
        transform.localScale = new Vector3(currentXValue, 1, 1);
    }
}
