using UnityEngine;

public class W13JumpScareAnim : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            animator.Play("JumpScare");
        }
    }
}
