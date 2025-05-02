using UnityEngine;

public class W12MoveTo : MonoBehaviour
{
    public GameObject target = null;
    public float mag = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if(target != null) {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, mag);
        }
    }
}
