using UnityEngine;

public class ProjectileW6 : MonoBehaviour
{
    // Setting the velocity to the right
    public Vector3 velocity = new Vector3(2, 0, 0);
    // The speed the projectile is traveling in
    public float speed;

    private void Start() {
        // Getting the mouse position on the screen
        Vector3 mouseScreenSpace = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // Converting the mouse position from screen position TO world position
        Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenSpace);
        // Making sure we only consider 2D position of the mouse
        mouseWorldSpace.z = 0;

        Vector2 toMouse = mouseWorldSpace - transform.position;

        // Using just the direction to the mouse and the magnitude from the speed
        velocity = toMouse.normalized * speed;
    }

    // Update is called once per frame
    void Update() {
        transform.position += velocity * Time.deltaTime;
    }
}
