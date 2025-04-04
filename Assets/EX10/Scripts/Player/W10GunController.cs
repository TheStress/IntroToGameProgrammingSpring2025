using UnityEngine;

public class W10GunController : MonoBehaviour
{
    W10Gun gun;
    public int shotgunShotCount;
    public float shotgunAngleOffset;
    public int circleShotCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        gun = GetComponent<W10Gun>();
    }

    // Update is called once per frame
    void Update() {
        // Regular Shot
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            gun.SpawnBulletAtAngle(0);
        }

        // Shotgun shot using while loop
        if (Input.GetKeyDown(KeyCode.Mouse1)) {
            int count = shotgunShotCount;
            while (count > 0) {
                gun.SpawnBulletAtAngle(0 + Random.Range(-shotgunAngleOffset, shotgunAngleOffset));
                count--;
            }
        }

        // Circle shot effect
        if (Input.GetKeyDown(KeyCode.Space)) {
            float currentAngle = 0;
            float angleIncrease = 360 / circleShotCount;
            for(int i = 0; i < circleShotCount; i++) {
                gun.SpawnBulletAtAngle(currentAngle);
                currentAngle += angleIncrease;
            }
        }
    }
}
