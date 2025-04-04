using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class W10UpgradeManager : MonoBehaviour
{
    List<GameObject> collectedUpgrades = new List<GameObject>();
    public float baseDamage;
    public float baseSpeed;
    W10Gun gun;

    private void Start() {
        gun = GetComponent<W10Gun>();
        ApplyBonuses();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Upgrade")) {
            collectedUpgrades.Add(collision.gameObject); // Adding object to list
            collision.gameObject.transform.position = new Vector3(100, 100, 100); // Moving the game object far away but keeping it alive for calculations
            ApplyBonuses();
        }
    }

    public void ApplyBonuses() {
        float totalBonusDamage = 0;
        float totalBonusSpeed = 0;

        // This will iterate through all the upgrades collected and add all the bonuses together
        foreach(GameObject currentUpgrade in collectedUpgrades) {
            W10Upgrade upgradeScript = currentUpgrade.GetComponent<W10Upgrade>(); // Getting the upgrade script from the game object
            totalBonusDamage += upgradeScript.damageBonus;
            totalBonusSpeed += upgradeScript.speedBonus;
        }

        gun.bulletDamage = baseDamage + totalBonusDamage; // Setting gun damage bonus
        gun.bulletSpeed = baseSpeed + totalBonusSpeed; // Setting gun speed bonus
    }
}
