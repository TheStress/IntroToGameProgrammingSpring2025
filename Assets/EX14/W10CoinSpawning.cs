using UnityEngine;

public class W10CoinSpawning : MonoBehaviour
{
    public GameObject coinPrefab; // The coin prefab
    public int spawnAmount = 3; // The amount of coins that will spawn
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) { // Pressing Space
            int i = 0; // Declaring variable to track how many times a coin spawns
            while (i < spawnAmount) { // While loop that ends when you spawn all the coins
                SpawnCoin(); // Spawning the coin in
                i++; // Increasing the tracker
            }
        }
    }
    public void SpawnCoin() {
        GameObject newCoin = Instantiate(coinPrefab, transform.position, Quaternion.identity); // Spawning in coin
        Rigidbody2D coinRB = newCoin.GetComponent<Rigidbody2D>(); // Getting the coin's rigidbody

        Vector2 randomForce = Random.insideUnitCircle * 1000; // Calculating force in random direction
        coinRB.AddForce(randomForce); // Applying the force
    }
}

