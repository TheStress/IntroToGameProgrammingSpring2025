using UnityEngine;

public class W10EnemyMove : MonoBehaviour
{
    public Vector3 moveDir;
    public float speed;

    void Update() 
    {
        // Very simple movement just moving in a single direction
        transform.position += moveDir.normalized * speed * Time.deltaTime;
    }
}
