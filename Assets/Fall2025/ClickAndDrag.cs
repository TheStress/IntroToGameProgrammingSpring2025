using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{

    private void Update() {
        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }


    //bool isAlive = false;
    //int playerScore = 10;
    //int scoreToWin = 10;
    //private void Update() {
    //    if(isAlive && playerScore == scoreToWin) {
    //        Debug.Log("Player Wins!");
    //    }
    //    else {
    //        Debug.Log("Player Loses!");
    //    }
    //}

    //private void Update() {
    //    transform.position = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);


    //    if(Input.GetKeyDown(KeyCode.Joystick1Button0)) {
    //        print("test");
    //    }
    //}

    //public bool onMouse = false;

    //// Update is called once per frame
    //void Update()
    //{
    //    Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Getting mouse world position


    //    // If its on the mouse then set the object to the mouse position
    //    if(onMouse) {
    //        transform.position = mouseWorldPosition;
    //    }

    //    // Releasing object
    //    if(Input.GetKeyUp(KeyCode.Mouse0)) {
    //        onMouse = false;
    //    }

    //    if(Input.GetKeyDown(KeyCode.Mouse0)) {

    //    }
    //}
}
