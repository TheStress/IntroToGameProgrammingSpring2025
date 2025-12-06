using System.Collections.Generic;
using UnityEngine;

public class HW7Spawner : MonoBehaviour
{
    public List<GameObject> enemyPrefabs;

    public float spawnRate = 5;
    public float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0) {
            for(int i = 0; i < 3; i++) {
                SpawnEnemy();
            }
            timer = spawnRate;
        }
    }

    public void SpawnEnemy() {
        int randomEnemyIndex = Random.Range(0, enemyPrefabs.Count);
        Vector3 offset = new Vector3(Random.Range(-6, 6), Random.Range(-2, 2), 0);
        Instantiate(enemyPrefabs[randomEnemyIndex], transform.position + offset, Quaternion.identity);
    }
}
