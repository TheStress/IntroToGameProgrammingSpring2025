using UnityEngine;

public class W10Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletDamage;
    public float bulletSpeed; 
    //public float fireRate; 
    //public float timer; // Timer to track the shooting cooldown
    public float bulletDirOffset; // The angle 


    private void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            SpawnBullet();
            SpawnBullet();
            SpawnBullet();
            SpawnBullet();
            SpawnBullet();
        }
        //timer -= Time.deltaTime;
    }

    //public void Shoot() {
    //    if (timer <= 0) {
    //        SpawnBullet();

    //        // Resetting the timer
    //        timer = fireRate;
    //    }
    //}

    public void SpawnBullet() {
        GameObject spawnedBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); // Spawning and storing the bullet created
        W10Bullet bullet = spawnedBullet.GetComponent<W10Bullet>(); // Getting the bullet script to adjust values

        // Setting up bullet stats
        bullet.damage = bulletDamage;
        Vector2 bulletDir = new Vector2(Random.Range(-bulletDirOffset, bulletDirOffset), 1f); // Setting up random dir
        bulletDir = bulletDir.normalized; // Normalizing direction to have it not affect speed
        bullet.velocity = bulletDir * bulletSpeed;
    }
}
