using UnityEngine;

public class W11MouseControls : MonoBehaviour
{
    public GameObject currentlyHolding = null;
    // Update is called once per frame
    void Update()
    {
        Vector2 mouseCoords = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Checking for object you can pick up when pressing down on mouse
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Collider2D foundCollider = Physics2D.OverlapPoint(mouseCoords); // Checking for collision at mouse position

            // If you find something
            if (foundCollider != null) {
                // If it has the can pick up tag then set it
                if (foundCollider.CompareTag("CanPickUp")) {
                    currentlyHolding = foundCollider.gameObject;
                }
            }
        }

        // If you are currently holding something hold it onto the mouse position
        if (Input.GetKey(KeyCode.Mouse0)) {
            if(currentlyHolding != null) {
                currentlyHolding.transform.position = mouseCoords;
            }
        }

        // If you are holding something and you release the mouse release the object
        if (Input.GetKeyUp(KeyCode.Mouse0)) {
            if (currentlyHolding != null) {
                currentlyHolding = null;
            }
        }
    }
}
