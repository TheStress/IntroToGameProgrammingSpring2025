using Unity.Collections;
using UnityEngine;

public class W9Health : MonoBehaviour
{
    public ParticleSystem bloodParticle;
    public AudioSource hurtAudio;

    private void Start() {
        bloodParticle = GetComponentInChildren<ParticleSystem>();
        hurtAudio = GetComponent<AudioSource>();
    }

    // Did not implement health but I just want to demonstrate taking damage
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.gameObject.CompareTag("Hazard")) {
            TakeDamage();
        }
    }
    public void TakeDamage() {
        // Emitting particles imediatly
        bloodParticle.Stop();
        bloodParticle.Play();

        // Only playing audio once its done playing
        if(!hurtAudio.isPlaying) {
            hurtAudio.Play();
        }
    }
}
