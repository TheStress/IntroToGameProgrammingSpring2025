using UnityEngine;

public class HW3AEnemyChasing : MonoBehaviour
{
    public GameObject playerObject;
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 dirToPlayer = playerObject.transform.position - transform.position;
        Vector3 velocity = dirToPlayer.normalized * speed;
        transform.position += velocity;
    }
}
