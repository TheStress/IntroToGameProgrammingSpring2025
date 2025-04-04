using UnityEngine;

public class W10Upgrade : MonoBehaviour
{
    public float damageBonus;
    public float speedBonus;
    public float maxDamageBonus;
    public float maxSpeedBonus;

    private void Start() {
        damageBonus = Random.Range(0, maxDamageBonus);
        speedBonus = Random.Range(0, maxSpeedBonus);
    }
}
