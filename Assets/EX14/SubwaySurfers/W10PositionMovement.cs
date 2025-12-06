using System.Collections.Generic;
using UnityEngine;

public class W10PositionMovement : MonoBehaviour {
    public List<GameObject> positions = new List<GameObject>(); // The list of game object used as positions
    public int positionIndex = 0; // The current position of the player

    private void Update() {
        // Moving down the list of saved indexes
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (positionIndex > 0) { // Checking if you can move left within the range of the list
                positionIndex -= 1;
            }
        }

        // Moving up the list of saved indexes
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            if (positionIndex < positions.Count - 1) { // Checking if you can move right within range of the list
                positionIndex += 1;
            }
        }
        
        GameObject positionObject = positions[positionIndex]; // Getting the object at the position
        transform.position = positionObject.transform.position; // Setting the current game object to that position
    }
}


