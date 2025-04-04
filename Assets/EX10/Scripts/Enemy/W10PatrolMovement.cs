using System.Collections.Generic;
using UnityEngine;

public class W10PatrolMovement : MonoBehaviour
{
    public List<GameObject> points;
    public int currentPoint = 0;
    public float speed;
    public float stoppingDistance;

    // Update is called once per frame
    void Update()
    {
        Vector3 vToPoint = points[currentPoint].transform.position - transform.position; // Getting vector to current point
        Vector3 dirToPoint = vToPoint.normalized; // Getting direction to that point, by normalizing it
        transform.position += dirToPoint * speed * Time.deltaTime; // Moving game object towards that point

        // Checking if this object has reached that point, if the distance between this object and the point are small
        if(vToPoint.magnitude < stoppingDistance) {
            currentPoint++; // if you have reached the point move onto the next one
            if(currentPoint >= points.Count) { // If there is no next one then go back to the first one
                currentPoint = 0;
            }
        }
    }
}
