using UnityEngine;

public class W13DamageFeedback : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // getting the sprite renderer
    public float flashDuration = 0.1f; // duration of the damage flash
    public float timer = 0; // timer keeping track of the flash duration

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            spriteRenderer.color = Color.red; // setting to damage color
            timer = flashDuration; // setting the flash timer
        }

        timer -= Time.deltaTime;
        if(timer <= 0) {
            spriteRenderer.color = Color.white; // resetting back to normal color after timer runs out
        }
    }
}
