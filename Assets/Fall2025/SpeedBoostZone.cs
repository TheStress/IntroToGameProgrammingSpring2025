using UnityEngine;

public class SpeedBoostZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) {
        collision.gameObject.GetComponent<ForceBasedMovement>().force += 100;
    }
}
