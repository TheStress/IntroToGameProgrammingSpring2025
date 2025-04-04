using UnityEngine;

public class W10DestroyOutOfBounds : MonoBehaviour
{
    public float distanceAwayFromOrigin;

    private void Update() {
        // Checking distance away from the center to destroy
        if(transform.position.magnitude > distanceAwayFromOrigin) {
            Destroy(gameObject);
        }
    }
}
