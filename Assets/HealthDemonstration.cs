using UnityEngine;

public class HealthDemonstration : MonoBehaviour {

    float currentHealth = 50;

    public void TakeDamage(float amount) {
        currentHealth -= amount;
        Debug.Log(currentHealth);
    }
}

