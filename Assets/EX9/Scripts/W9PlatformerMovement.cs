using UnityEngine;

public class W9PlatformerMovement : MonoBehaviour
{
    public float speed = 10; // how fast the player is moving left and right
    public float jumpForce = 100; // How much force is added upward when the player jumps
    Rigidbody2D _rb;

    public float groundCheckOffset;
    public Vector2 groundCheckSize;
    public LayerMask groundMask;

    public Animator animator;
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Getting all the components we need
        _rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Finding the horizontal input 1 to move right and -1 to move left
        int horizontalInput = 0;
        if (Input.GetKey(KeyCode.D)) {
            horizontalInput += 1; // adding 1 onto 
        }
        if (Input.GetKey(KeyCode.A)) {
            horizontalInput -= 1;
        }
        // We add the values because if the player is pressing both A and D will result in a 0 horizontal input


        // Jumping input
        bool onGround = OnGround();
        if(Input.GetKeyDown(KeyCode.Space) && onGround) {
            Vector2 jumpVector = new Vector2(0, jumpForce);
            _rb.AddForce(jumpVector, ForceMode2D.Impulse);
        }


        // Adding force for horizontal movement
        Vector2 forceAdd = new Vector2(horizontalInput*speed, 0)*Time.deltaTime; // Calculating force added into a vector and scaling it by time
        _rb.AddForce(forceAdd, ForceMode2D.Impulse);


        // Playing a single animation by pressing E, 
        if(Input.GetKeyDown(KeyCode.E)) {
            animator.Play("Walk");
        }

        // Animations
        if(horizontalInput == -1) {
            spriteRenderer.flipX = true;
        }
        else if(horizontalInput == 1){
            spriteRenderer.flipX = false;
        }

        animator.SetFloat("HorizontalSpeed", _rb.linearVelocity.x); // Setting animation parameeter using horizontal velocity
        animator.SetFloat("VerticalSpeed", _rb.linearVelocity.y); // Setting animation parameter using vertical velocity
    }

    public bool OnGround() {
        Vector3 groundOffset = new Vector3(0, groundCheckOffset, 0); // Getting the offset form the player center
        Collider2D found = Physics2D.OverlapBox(transform.position + groundOffset, groundCheckSize, 0, groundMask); // Checking overlap
        return found; // Converts collider to a boolean, if its null then it returns false, if there is a collider it returns true
    }

    // Debugging tool that draws the hitbox that is checking for the ground, the groundOffset variable below is the same cod as the one above in the OnGround()
    private void OnDrawGizmos() {
        Vector3 groundOffset = new Vector3(0, groundCheckOffset, 0);
        Gizmos.DrawCube(transform.position + groundOffset, groundCheckSize);
    }
}
