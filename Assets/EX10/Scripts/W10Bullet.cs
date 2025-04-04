using Unity.VisualScripting;
using UnityEngine;

public class W10Bullet : MonoBehaviour {
    public Vector2 velocity;
    public string targetTag;
    public float damage;

    private void Update() {
        transform.position += new Vector3(velocity.x, velocity.y, 0) * Time.deltaTime; // Moving the bullet
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        GameObject collidedObject = collision.gameObject; // Storing the game object the bullet collided with
        if (collidedObject.CompareTag(targetTag)) { // Checking if the target is the correct tag

            /* Checking if the object collided with contains a "W10Health" script, this function will return false, 
             * if there isnt one it will return false and the if statement will be skipped
             * if there is one then the if statement will run and the found "W10Health" script will be stored 
             * in the "foundHealth" variable
            */
            if (collidedObject.TryGetComponent<W10Health>(out W10Health foundHealth)) {
                foundHealth.TakeDamage(damage); // Dealing damage to the collided object
            }


            Destroy(gameObject); // Finally destroying bullet
        }
    }
}
