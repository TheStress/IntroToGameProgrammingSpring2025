using UnityEngine;

public class W10Background : MonoBehaviour
{
    public float tileFactor = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime; // Move background down

        // Once it goes past the tile factor you reset the position
        if(transform.position.y < -tileFactor) {
            transform.position = Vector3.zero;
        }
    }
}
