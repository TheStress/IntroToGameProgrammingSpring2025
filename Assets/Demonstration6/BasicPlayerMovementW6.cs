using UnityEngine;

public class BasicPlayerMovementW6 : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        //The code below controls the character's movement
        //First we make a variable that we'll use to record how we want to move
        Vector2 vel = new Vector2(0, 0);

        //Then we use if statement to figure out what that variable should look like

        //If I hold the right arrow key, the player should move right. . .
        if (Input.GetKey(KeyCode.RightArrow)) {
            vel.x = Speed;
        }
        //If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.LeftArrow)) {
            vel.x = -Speed;
        }
        //If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.UpArrow)) {
            vel.y = Speed;
        }
        //If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.DownArrow)) {
            vel.y = -Speed;
        }

        //Finally, I take that variable and I feed it to the component in charge of movement
        rb.linearVelocity = vel;
    }
}
