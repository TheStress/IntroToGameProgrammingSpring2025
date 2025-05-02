using UnityEngine;

public class W13JumpScareScale : MonoBehaviour
{
    public float targetScale = 5f; // the max scale this object is going to reach
    public float growSpeed = 2f; // how fast the scale is going to grow
    public bool isJumpscareActive = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0); // Starting the scale as 0 so its invisible
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) {
            isJumpscareActive = true; // activating jumpscare when spacebar is pressed
        }

        if (isJumpscareActive) {
            float currentScale = transform.localScale.x; // getting the current scale
            currentScale += Time.deltaTime*growSpeed; // increasing the current scale
            transform.localScale = new Vector3(currentScale, currentScale, currentScale); // applying new scale

            if(currentScale >= targetScale) { // checking if the current scale reached the max
                transform.localScale = new Vector3(0, 0, 0); // resetting scale to 0
                isJumpscareActive = false; 
            }
        }
    }
}
