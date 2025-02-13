using UnityEngine;

public class EX3_1Health : MonoBehaviour
{
    public float currentHealth = 0f;
    public float maxHealth = 100f;
    public float healthRegen = 0.01f;
    public float poisonDamage = 0.001f;

    // Update is called once per frame
    void Update() {
        currentHealth += healthRegen;
        currentHealth -= poisonDamage;

        if(currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }

        if(currentHealth < 0) {
            currentHealth = 0;
        }

        Debug.Log(currentHealth);
    }
}
