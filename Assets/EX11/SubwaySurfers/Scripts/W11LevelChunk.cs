using UnityEngine;

public class W11LevelChunk : MonoBehaviour
{
    public float speed;
    public float destoryDist;

    private void Update() {
        transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime; // Moving Down

        // If the chunk is far enough off the edge of the screen delete itself
        if(transform.position.y < -Mathf.Abs(destoryDist)) {
            Destroy(gameObject);
        }
    }
}
