using UnityEngine;

public class W10Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletDamage;
    public float bulletSpeed; 

    // Spawn a bullet at a precise angle
    public void SpawnBulletAtAngle(float angle) {
        GameObject spawnedBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); // Spawning and storing the bullet created
        W10Bullet bullet = spawnedBullet.GetComponent<W10Bullet>(); // Getting the bullet script to adjust values

        // Setting up bullet stats 
        bullet.damage = bulletDamage;
        Quaternion rotationToApply = Quaternion.Euler(new Vector3(0, 0, angle)); // Setting up euler rotation to apply
        Vector2 bulletDir = rotationToApply * new Vector2(0, 1f); // Applying rotation to direction vector
        bulletDir = bulletDir.normalized; // Normalizing direction to have it not affect speed
        bullet.velocity = bulletDir * bulletSpeed;
    }
}
