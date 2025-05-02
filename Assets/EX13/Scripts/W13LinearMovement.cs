using UnityEngine;

public class W13LinearMovement : MonoBehaviour
{
    public Vector3 targetPosition; // the target position the object is moving towards
    public float speed; // how fast this object will move towards the target

    // Update is called once per frame
    void Update()
    {
        Vector3 dirToTarget = targetPosition - transform.position; // finding the direction to target
        dirToTarget = dirToTarget.normalized; // normalizing direction to make sure the length is just 1

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //transform.position += dirToTarget * speed * Time.deltaTime; // Moving towards target at a constant speed
    }
}
