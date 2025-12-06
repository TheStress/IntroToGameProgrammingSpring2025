using System.Collections.Generic;
using UnityEngine;

public class W10ProceduralSpawning : MonoBehaviour {
    public List<GameObject> levelChunks = new List<GameObject>(); // List of obstical prefabs to spawn

    public float timer = 0; // Timer to keep track of the current cooldown for spawning in a chunk
    public float spawnRate = 5; // The rate at witch obsticals spawn in

    // Update is called once per frame
    void Update() {
        timer -= Time.deltaTime; // Counting down the timer
        if(timer <= 0) {
            SpawnRandomObstical(); // Spawning Chunk
            timer = spawnRate; // Resetting Timer
        }
    }
    public void SpawnRandomObstical() {
        int randomI = Random.Range(0, levelChunks.Count); // Selecting random index in the list of obsticals
        Instantiate(levelChunks[randomI], transform.position, Quaternion.identity); // spawning it in and returning the game object
    }
}


