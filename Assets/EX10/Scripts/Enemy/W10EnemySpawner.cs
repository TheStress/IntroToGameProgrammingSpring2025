using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class W10EnemySpawner : MonoBehaviour
{
    public float spawnRate;
    public float spawnTimer;
    public Vector2 spawnPositionOffset;
    public List<GameObject> enemyPrefabs;

    private void Update() {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0) {
            GameObject selectedEnemy = GetRandomEnemy();
            SpawnEnemy(selectedEnemy);

            spawnTimer = spawnRate;
        }
    }

    public GameObject GetRandomEnemy() {
        int numberOfEnemies = enemyPrefabs.Count;
        int randomIndex = Random.Range(0, numberOfEnemies);
        return enemyPrefabs[randomIndex];
    }

    public void SpawnEnemy(GameObject enemy) {
        Vector2 spawnPosition = new Vector2(Random.Range(-spawnPositionOffset.x, spawnPositionOffset.x), spawnPositionOffset.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
