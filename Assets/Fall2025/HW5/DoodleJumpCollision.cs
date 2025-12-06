using UnityEngine;

public class DoodleJumpCollision : MonoBehaviour {
    public Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        rb.linearVelocity = Vector3.up * 25f;
    }
}
