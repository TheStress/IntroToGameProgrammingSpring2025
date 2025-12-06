using UnityEngine;

public class PipeCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) { // Event function that triggers this object collides with an object
        GameObject collidedGameObject = collision.gameObject; // Getting the gameobject you collided with
        if(collidedGameObject.CompareTag("Player")) { // Checking if the object you collided with has the "Player" tag
            FlappyBirdMovement playerControls = collidedGameObject.GetComponent<FlappyBirdMovement>(); // Getting the movement script from this object
            playerControls.Die(); // Running the die function
        }
    }
}


