using System.Collections.Generic;
using UnityEngine;

public class W11LevelGenerator : MonoBehaviour
{
    public List<GameObject> levelChunks = new List<GameObject>();
    public GameObject currentChunk = null;
    public float spawnDistance = 5; // how far away the current chunk needs to be to spawn the next one

    private void Start() {
        // spawning in the first chunk
        currentChunk = SpawnRandomChunk();
    }

    // Update is called once per frame
    void Update()
    {
        // Checking the distance away from the current chunk to spawn the next one
        float yDistance = Mathf.Abs(currentChunk.transform.position.y - transform.position.y);
        if (yDistance > spawnDistance) {
            currentChunk = SpawnRandomChunk();
        }
    }

    public GameObject SpawnRandomChunk() {
        int randomI = Random.Range(0, levelChunks.Count); // Selecting random chunk
        return Instantiate(levelChunks[randomI], transform.position, Quaternion.identity); // spawning it in and returning the game object
    }
}
