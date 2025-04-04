using System;
using UnityEngine;

public class W10EnemyShooter : MonoBehaviour {
    public GameObject bulletPrefab;
    public float bulletDamage;
    public float bulletSpeed;
    public float fireRate;
    public float timer;

    public bool spreadShot;
    public float spreadAngle;

    private void Update() {
        // Shooting bullets based on firerate
        timer -= Time.deltaTime;
        if(timer <= 0) {
            Vector3 dirToPlayer = DirectionToPlayer();

            // Spreadshot option for the enemy
            if (spreadShot) {
                SpawnBullet(dirToPlayer); // Shooting at the player

                // When you multiply a quaternion from the left to a vector it applies the rotation to the vector
                SpawnBullet(Quaternion.Euler(new Vector3(0, 0, spreadAngle)) * dirToPlayer);
                SpawnBullet(Quaternion.Euler(new Vector3(0, 0, -spreadAngle)) * dirToPlayer);
            }
            else {
                SpawnBullet(dirToPlayer);
            }

            timer = fireRate; // Resetting timer
        }
    }

    public void SpawnBullet(Vector2 bulletDir) {
        GameObject spawnedBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); // Spawning and storing the bullet created
        W10Bullet bullet = spawnedBullet.GetComponent<W10Bullet>(); // Getting the bullet script to adjust values

        // Setting up bullet stats
        bullet.damage = bulletDamage;
        bullet.velocity = bulletDir * bulletSpeed;
    }

    public Vector3 DirectionToPlayer() {
        GameObject player = FindFirstObjectByType<W10PlayerScript>().gameObject; // Getting player object
        Vector3 dirToPlayer = player.transform.position - transform.position; // Calculating direction to player
        return dirToPlayer.normalized;
    }
}
