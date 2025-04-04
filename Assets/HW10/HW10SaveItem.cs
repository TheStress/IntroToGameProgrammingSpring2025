using UnityEngine;

public class HW10SaveItem : MonoBehaviour
{
    Vector3 savePosition;
    Vector3 saveScale;
    Quaternion saveRotation;
    public void Save() {
        savePosition = transform.position;
        saveScale = transform.localScale;
        saveRotation = transform.rotation;
    }

    public void Load() {
        transform.position = savePosition;
        transform.localScale = saveScale;
        transform.rotation = saveRotation;
    }
}
