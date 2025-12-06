using UnityEngine;

public class WrapAround : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 10) {
            transform.position = new Vector3(-10, transform.position.y);
        }
        if (transform.position.x < -10) {
            transform.position = new Vector3(10, transform.position.y);
        }
        if (transform.position.y > 8) {
            transform.position = new Vector3(transform.position.x, -8);
        }
        if (transform.position.y < -8) {
            transform.position = new Vector3(transform.position.x, 8);
        }
    }
}
