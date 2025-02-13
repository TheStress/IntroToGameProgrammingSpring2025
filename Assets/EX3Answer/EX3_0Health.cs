using UnityEngine;

public class EX3_0Health : MonoBehaviour
{
    public float currentHealth = 0f;
    public float healthRegen = 0.01f;

    // Update is called once per frame
    void Update() {
        currentHealth += healthRegen;
        Debug.Log(currentHealth);
    }
}