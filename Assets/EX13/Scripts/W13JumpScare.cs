using UnityEngine;

public class W13JumpScare : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public float jumpScareDuration = 0.1f;
    public float jumpScareTimer = 0;
    public bool isJumpScareActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer.enabled = false; // start the jump scare off disabled
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) { // Activating jumpscare when you press space
            isJumpScareActive = true;
            spriteRenderer.enabled = true; // displaying jumpsacre sprite
            jumpScareTimer = jumpScareDuration; // setting up the timer for jumpscare duration
        }

        if(isJumpScareActive) { // Only activiating if there is a timer
            jumpScareTimer -= Time.deltaTime; // counting down the timer
            if(jumpScareTimer <= 0) { // Once the timer is over disable it
                isJumpScareActive = false; // disabing the jumpscare if statement
                spriteRenderer.enabled = false; // Disabling the sprite
            }
        }
    }
}
