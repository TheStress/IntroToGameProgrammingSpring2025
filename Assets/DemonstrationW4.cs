using UnityEngine;

public class DemonstrationW4 : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision) {
        // Getting the other game object
        GameObject otherGameObject = collision.gameObject;

        if(otherGameObject.CompareTag("Player")) {
            Debug.Log("Collided with Player");
        }
        if(otherGameObject.layer == 7) {
            Debug.Log("Collided with Ground Layer");
        }
    }
}


//private void OnTriggerEnter2D(Collider2D collision) {
//    // Getting the other game object you collided with
//    GameObject collidedObject = collision.gameObject;


//    // Checking if this object has the Player tag
//    if(collidedObject.CompareTag("Player")) {

//        // If it does get the health components off of it
//        HealthDemonstration health = collision.gameObject.GetComponent<HealthDemonstration>();

//        // Finally deal the damage
//        health.TakeDamage(1);
//    }
//}


//HealthDemonstration healthDemonstration;
//private void Start() {
//    healthDemonstration = GetComponent<HealthDemonstration>();
//    healthDemonstration.TakeDamage(5f);
//}

//float currentHealth = 50;
//float maxHealth = 100;

//float value1 = 10;
//float value2 = 20;
//private void Start() {
//    float total1 = AddTwoNumbers(1, 2); // Value stored in total1 would be 3
//    float total2 = AddTwoNumbers(100, 500); // Value stored in total2 would be 400
//    float total3 = AddTwoNumbers(value1, value2); // Value stored in total3 would be 30
//}
//public float AddTwoNumbers(float input1, float input2) {
//    float total = input1 + input2;
//    return total;
//}

//public float GetHealthPercent() {
//    float percentHealth = currentHealth / maxHealth;
//    return percentHealth;
//}

//public void TakeDamage(float amount) {
//    currentHealth -= amount;
//}

//public void Die() {
//    Debug.Log("GameObject is dead!");
//}




//AddSixNumbers(1, 20, new Vector3(0, 0, 0), 40, "Name", true);

//public float AddSixNumbers(float input1, float input2, float input3, float input4, float input5, float input6) {
//    float total = input1 + input2 + input3 + input4 + input5 + input6;
//    return total;
//}



//if (AlwaysOutputTrue()) {
//    Debug.Log("Always True");
//}

//public bool AlwaysOutputTrue() {
//    return true;
//    Debug.Log("Trying to Print");
//    float testVariables = 1.0f;

//}


//public float GetCurrentHealth() {
//    return currentHealth;
//}
//float speed = 5;
//public void MoveRight() {
//    transform.position += new Vector3(speed, 0, 0);
//}
//float rotationValue = 0;
//float rotationSpeed = 0.1f;



//public void UpdateRotation() {
//    rotationValue += rotationSpeed;
//    transform.rotation = Quaternion.Euler(0, 0, rotationValue);
//}

//    public float GetCurrentHealth() {
//        return currentHealth;
//    }



//    public void PrintOk() {
//        Debug.Log("Ok");
//    }


//    public int AddTwoNumberes(int input1, int input2) {
//        return input1 + input2;
//    }
//}

//    public string GetNelson() {
//    return "Nelson";
//}
//public float GetPI() {
//    return 3.14f;
//}

//public bool GetTrue() {
//    return true;
//}
//public Vector3 GetPosition() {
//    return new Vector3(0, 0, 0);
//}


//if (Input.GetKeyDown(KeyCode.Space)) {
//    Debug.Log("Pressed Space");
//}

//Debug.Log("Game Started");
//Vector3 vector3Variable = new Vector3(0, 0, 0);
