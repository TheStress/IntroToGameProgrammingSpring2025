using UnityEngine;

public class TeleportAtStart : MonoBehaviour
{
    public Vector3 location;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = location;
    }
}
