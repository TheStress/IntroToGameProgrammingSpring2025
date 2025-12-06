using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public float trauma; // The value we track to convert to screen shake
    public float magnitude = 1; // The amount we scale the screen shake by
    public Vector3 startingPosition; // The starting position where the camera will screen shake around
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        startingPosition = transform.position; // Setting the camera to the start 
    }

    // Update is called once per frame
    void Update() {
        trauma -= Time.deltaTime; // Reducing trauma over time
        if(trauma < 0) { // Clamping to make sure trauma value doesnt go below 0
            trauma = 0;
        }

        // Applying screen shake by randomly moving transform
        transform.position = startingPosition + (new Vector3(Random.Range(-1,1), Random.Range(-1,1), 0) * magnitude * Mathf.Pow(trauma, 2));

        if (Input.GetKeyDown(KeyCode.Space)) { // Applying screenshake manually, usually this should be executed by other code
            AddTrauma(0.5f);
        }
    }

    // Function used to add trauma, to be used by other code
    public void AddTrauma(float amount) {
        trauma += amount;
    }
}


