using UnityEngine;

public class W10Health : MonoBehaviour
{
    public float health;
    public float healthMax;

    // Color flash
    Color originalColor;
    SpriteRenderer spriteRenderer;
    bool colorFlashed = false;
    float flashTime = 0.1f;
    float timer;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color; // Getting original color
        timer = flashTime;
    }

    private void Update() {
        if(colorFlashed) { // Only when the color is on
            timer -= Time.deltaTime;
            if(timer <= 0) {
                // Resetting color, timer, and flash boolean
                spriteRenderer.color = originalColor;
                colorFlashed = false;
                timer = flashTime;
            }
        }
    }

    public void TakeDamage(float amount) {

        spriteRenderer.color = Color.white; // White color flash for feedback
        colorFlashed = true; 

        health -= amount;
        if(health < 0) {
            Die();
        }
    }
    public void Die() {
        Destroy(gameObject);
    }
}
