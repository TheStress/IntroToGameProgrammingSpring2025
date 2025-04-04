using UnityEngine;
using UnityEngine.UIElements;

public class W10UpgradeSpawner : MonoBehaviour
{
    public GameObject upgradePrefab;
    public Vector2 positionRange;
    public float spawnRate;
    public float timer;

    private void Start() {
        timer = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0) {
            // Getting random position between 2 ranges
            Vector2 position = new Vector2(Random.Range(-positionRange.x, positionRange.x), Random.Range(-positionRange.y, positionRange.y));
            Instantiate(upgradePrefab, position, Quaternion.identity); // Spawning upgrade
            timer = spawnRate; // Resetting timer
        }
    }
}
