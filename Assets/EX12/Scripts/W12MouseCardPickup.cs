using UnityEngine;

public class W12MouseCardPickup : MonoBehaviour
{
    GameObject currentlyHeld = null;
    Vector3 targetPosition = new Vector3(0,0,0);
    public float mag = 0.5f;

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Collider2D found = Physics2D.OverlapPoint(mousePos);
            if(found != null) {
                currentlyHeld = found.gameObject;
            }
        }
        if(Input.GetKeyUp(KeyCode.Mouse0) && currentlyHeld != null) {
            currentlyHeld = null;
        }

        if (currentlyHeld != null) {
            Vector3 dirToMousePos = new Vector3(mousePos.x, mousePos.y, 0) - currentlyHeld.transform.position;
            currentlyHeld.transform.position = Vector3.Lerp(currentlyHeld.transform.position, mousePos, mag);
        }
    }
}
