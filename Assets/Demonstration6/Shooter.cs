using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    //float total = 0;
    public float timer = 10;
    public float shotCoolDown = 0.5f;

    void Update() {
        //Vector3 moveRight = new Vector3(5, 0, 0);
        //transform.position += moveRight * Time.deltaTime;

        timer -= Time.deltaTime;
        if(timer <= 0 && Input.GetKey(KeyCode.Mouse0)) {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            timer = shotCoolDown;
        }
    }


}
