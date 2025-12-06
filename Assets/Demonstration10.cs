using UnityEngine;

public class Demonstration10 : MonoBehaviour
{
    //public Vector3 targetLocation = new Vector3(0, 0, 0);
    //public float speed = 0.01f;

    //// Update is called once per frame
    //void Update()
    //{
    //    Vector3 vectorToTarget = targetLocation - transform.position; // Getting the vector to the target
    //    Vector3 directionToTarget = vectorToTarget.normalized; // Normalizing the direction so the length equals 1
    //    Vector3 velocity = directionToTarget * speed; // Calculating the velocity vector we are going to use to move the object

    //    transform.position += velocity; // Moving the object
    //}


    public Sprite newSprite;
    public SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Getting the sprite renderer
        spriteRenderer.sprite = newSprite; // Setting a new sprite
        spriteRenderer.color = Color.red; // You can set the color using
        spriteRenderer.color = new Vector4(1,1,1,1); // Colors are actually just 4 numbers (red,green,blue,alpha)
        spriteRenderer.flipX = false; // Setting the xflip
        spriteRenderer.flipY = false; // Setting the yflip
    }
}
