using UnityEngine;
using UnityEngine.SceneManagement;


public class DemonstrationW5 : MonoBehaviour {
    private void Update() {


        if(Random.value < 0.5) { // This will be true 50% of the time
            Debug.Log("Coin flip successful");
        }

        float randomXpos = Random.Range(-10, 10); // random value between -10 to 10
        float randomYPos =  Random.Range(-5, 5); // random value between -5 to 5
        transform.position = new Vector3(randomXpos, randomYPos, 0); // Setting the random position
    }
}

//public GameObject test;
//private void Update() {
//    Vector2 mouseInput = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
//    if(Input.GetKey(KeyCode.Space)) {
//        Instantiate(test, mouseInput, Quaternion.identity);
//    }
//    // Prints the amount of time that has passed between updates
//    Debug.Log(Time.deltaTime);
//}


//float timer = 0; // The variable that is counting down
//float shotCoolDown = 10;

//private void Start() {
//    timer = shotCoolDown; // Resetting the timer at the start of the game
//}
//private void Update() {
//    timer -= Time.deltaTime; // Decreasing the timer by the amount of time passin 
//    if(timer <= 0) {
//        Debug.Log("Code that you want to execute"); // Any of the code you wanted to execute after the amount of time
//        timer = shotCoolDown; // Resetting the timer
//    }
//}

//static class GlobalClassExample {
//    static public int globalInt = 10; // Globally accessible variable
//    static public int AddTwoInt(int input1, int input2) { // helper like function 
//        return input1 + input2;
//    }
//}


//public class Gun {
//    public int ammo = 0;
//    public Gun(int initalAmmo) {
//        ammo = initalAmmo;
//    }
//    public void ShootInput() {
//        if (ammo > 0) { // Checking if the gun has ammmo
//            ammo -= 1; // Decreasing ammo
//            SpawnBullet(); // Spawning bullet
//        }
//    }
//    private void SpawnBullet() { // private inaccessible function
//        Debug.Log("Shooting");
//    }
//}


//public class MachineGun : Gun {
//    public MachineGun(int initalAmmo) : base(initalAmmo){
//        ammo = initalAmmo;
//    }
//}

//public class ShotGun : Gun {
//    public ShotGun(int initalAmmo) : base(initalAmmo) {
//        ammo = initalAmmo;
//    }
//}


//// Spawn a bullet at the current position of this object with 0 rotation
//Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 0));

//Debug.Log(Time.deltaTime); // Print out the time between each update, measured seconds
//Debug.Log(Mathf.Sqrt(25)); // Prints out the square root of 25, which is 5
//Debug.Log(Input.GetKeyDown(KeyCode.Space)); // Prints out true or false if spacebar is pressed

//private void Start() {
//    Debug.Log(GlobalClassExample.globalInt); // printing out 10
//    Debug.Log(GlobalClassExample.AddTwoInt(1, 2)); // printing out 3
//}


//SpriteRenderer spriteRenderer;
//private void Start() {
//    spriteRenderer = GetComponent<SpriteRenderer>();
//}
//private void Update() {
//    transform.position += new Vector3(1, 0, 0);
//}

//Gun gun = new Gun(10); // Declaring a gun variable
//if (Input.GetKeyDown(KeyCode.Space)) { // If space is pressed
//    gun.ShootInput(); // Shooting gun
//}

//void Start() {
//    Debug.Log(gun.maxAmmo); // Accessing maxAmmo
//    Debug.Log(gun.ammo); // Access a class variable
//    gun.ShootInput(); // Using ShootInput()
//    gun.SpawnBullet(); // TRYING to use SpawnBullet()
//}

//    public void ShootInput() {
//        Debug.Log("Shoot Input");
//    }
//    private void SpawnBullet() {
//        Debug.Log("Spawn Bullet");
//    }
//}
