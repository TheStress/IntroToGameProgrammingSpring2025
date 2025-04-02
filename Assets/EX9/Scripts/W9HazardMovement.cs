using UnityEngine;

public class W9HazardMovement : MonoBehaviour {
    
    public int moveDirection = 1;
    public float moveSpeed = 2;
    public float offsetLimit = 3;
    public Vector3 initalPosition;
    public Vector3 offSet = new Vector3(0, 0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        initalPosition = transform.position; // getting the inital position at the start of the game
    }

    // Update is called once per frame
    void Update() {
        float calculatedIncrease = moveSpeed*moveDirection*Time.deltaTime; // Calculating how much something is increasing using the scale, direction, and scaling by time
        Vector3 increase = new Vector3(calculatedIncrease, 0, 0); // Creating a vector3 to increase the offset
        offSet += increase; // Adding to the offset
        transform.position = initalPosition + offSet; // finally setting the position off the intial positoin

        // If the offset is far enough away form the intial position to reach the offset reverse the direction
        if(moveDirection == 1) {
            if (offSet.x > offsetLimit) {
                moveDirection = -moveDirection;
            }
        }
        else if(moveDirection == -1) {
            if (offSet.x < -offsetLimit) {
                moveDirection = -moveDirection;
            }
        }
    }
}
