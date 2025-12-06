using UnityEngine;

public class W10SpawningObsticals : MonoBehaviour {
    public GameObject obstaclePrefab; // The obstical prefab
    public int spawnAmount = 3; // The amount of obsticals that will spawn
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) { // Pressing Space
            for(int i = 0; i < 8; i++) { // For loop iterating through 
                for (int j = 0; j < 6; j++) {
                    Vector3 offset = new Vector3(2 * i, 2 * j, 0); // Calculating offset
                    Vector3 obsticalPosition = transform.position + offset;  // Calculating obstical position 
                    Instantiate(obstaclePrefab, obsticalPosition, Quaternion.identity); // Spawning in obstical
                }
            }
        }
    }
}


