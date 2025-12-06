using UnityEngine;

public class StickToMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }
}
