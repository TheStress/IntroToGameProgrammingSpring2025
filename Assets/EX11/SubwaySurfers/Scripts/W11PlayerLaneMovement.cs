using System.Collections.Generic;
using UnityEngine;

public class W11PlayerLaneMovement : MonoBehaviour
{
    public List<GameObject> positions = new List<GameObject>();
    public int positionIndex = 0;

    private void Update() {
        // Moving down the list of saved indexes
        if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            if(positionIndex > 0) {
                positionIndex -= 1;
            }
        }

        // Moving up the list of saved indexes
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            // You need to minus 1 to make sure its in the range of the list
            if(positionIndex < positions.Count-1) {
                positionIndex += 1;
            }
        }

        // Setting the current position to the saved indexes
        GameObject positionObject = positions[positionIndex];
        transform.position = positionObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        // When you collided with a hazard destory self
        if(collision.gameObject.CompareTag("Hazard")) {
            Destroy(gameObject);
        }
    }
}
