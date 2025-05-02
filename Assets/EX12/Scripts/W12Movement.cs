using UnityEngine;

public class W12Movement : MonoBehaviour
{
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        Vector2 inputDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += new Vector3(inputDir.x, inputDir.y, 0) * speed * Time.deltaTime;
    }
}