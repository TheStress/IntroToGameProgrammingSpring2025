using UnityEngine;

public class W10Health : MonoBehaviour
{
    public float health;
    public float healthMax;

    public void TakeDamage(float amount) {
        health -= amount;
        if(health < 0) {
            Die();
        }
    }

    public void Die() {
        Destroy(gameObject);
    }
}
