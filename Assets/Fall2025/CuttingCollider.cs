using UnityEngine;

public class CuttingCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) { // Code that Triggers when this object collides with other objects as a trigger
        GameObject collidedObject = collision.gameObject; // Getting the other game object when colliding
        if(collidedObject.CompareTag("Fruit")) { // Checking if the collided object has the fruit tag
            FruitHealth fruitHealth = collidedObject.GetComponent<FruitHealth>(); // Gets the fruit health component 
            fruitHealth.Cut(); // Calling the cut function on the fruit health to change the color
        }
    }
}

