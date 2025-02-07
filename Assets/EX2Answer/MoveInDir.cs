using UnityEngine;

public class MoveInDir : MonoBehaviour
{
    public Vector3 dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir;
    }
}
