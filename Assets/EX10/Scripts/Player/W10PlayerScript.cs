using UnityEngine;

public class W10PlayerScript : MonoBehaviour {


    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Getting the position of the mouse in world space
        transform.position = mousePos; // Setting the game object position to the mouse position
    }
}
