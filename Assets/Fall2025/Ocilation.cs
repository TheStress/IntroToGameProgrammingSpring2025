using UnityEngine;

public class Ocilation : MonoBehaviour
{
    bool movingRight = true;
    private void Update() {
        movingRight = !movingRight; // you can reverse a boolean easily with this 
    }

    //public float speed = 0.1f;
    //public bool movingRight = true;

    //public float distanceTraveledAway = 0f;
    //public float distanceToReverse = 3f;
    //private void Update() {
    //    if(movingRight) { // Checking if this object is moving to the right
    //        transform.position += new Vector3(1, 0, 0) * speed; // Move it to the right
    //        distanceTraveledAway += speed; // Tracking how far the object has traveled to the right
    //    }
    //    else { // else this object moves to the left
    //        transform.position += new Vector3(-1, 0, 0) * speed; // Move it to the left
    //        distanceTraveledAway -= speed; // Tracking how far the object has traveled to the left
    //    }


    //    if(distanceTraveledAway > distanceToReverse) { // if the object has traveled away from the threshold
    //        movingRight = false; // Set to move to the left
    //    }
    //    if(distanceTraveledAway < -distanceToReverse) { // if the object has traveled away from the threshold
    //        movingRight = true; // Set to move to the left
    //    }
    //}


    //public float speed = 0.01f;
    //public int direction = 1;
    //public float offset = 0;
    //public float offsetAmount = 5;
    //// Update is called once per frame
    //void Update()
    //{
    //    // Movement
    //    transform.position += direction * speed * Vector3.right;

    //    // Offset tracking
    //    offset += direction * speed;

    //    // Reversing direction
    //    if(offset > direction * offsetAmount) {
    //        direction = -1;
    //    }
    //    if(offset < direction * offsetAmount) {
    //        direction = 1;
    //    }





    //    if (true) {
    //        Debug.Log("Hello World");
    //    }
    //}
}
