using UnityEngine;

public class FruitHealth : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Declaring variable for sprite renderer
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Getting sprite Renderer on the game object
    }
    public void Cut() { // Cut function that is run when the cut collider contacts the 
        spriteRenderer.color = Color.red; // Change the color of the fruit to red
    }
}


