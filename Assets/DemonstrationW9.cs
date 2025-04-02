using UnityEngine;

public class DemonstrationW9 : MonoBehaviour {

    public ParticleSystem particle;


    public AudioSource source;
    public AudioClip clip;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            source.PlayOneShot(clip);
        }
    }

}



    //public int score = 10;
    //public int scoreToTriggerSomething = 10;
    //void Update()
    //{
    //    if(score > scoreToTriggerSomething) {
    //        // Do something
    //    }
    //}
