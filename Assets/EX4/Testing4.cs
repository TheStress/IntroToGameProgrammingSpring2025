using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Testing4 : MonoBehaviour
{
    //public GameObject coinPrefab;
    float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        timer -= Time.deltaTime;
        Debug.Log(timer);
        //Vector3 offset = new Vector3(2, 0, 0);
        //if (Input.GetKeyDown(KeyCode.Space)) {
        //    //Instantiate(coinPrefab, transform.position+ offset, Quaternion.identity);
        //    //transform.rotation = Quaternion.Euler(0,0,0);
        //    //Destroy(gameObject);
        //    SceneManager.LoadScene("CheckScene");
        //}
    }

    //private void OnCollisionEnter2D(Collision2D collision) {
    //    Debug.Log("enter");
    //}
    //private void OnCollisionStay2D(Collision2D collision) {
    //    Debug.Log("stay");

    //}
    //private void OnCollisionExit2D(Collision2D collision) {
    //    Debug.Log("exit");
    //}

    //private void OnTriggerEnter2D(Collider2D collision) {
    //    if (collision.gameObject.tag == "Player") {
    //        Debug.Log("trigger enter");
    //    }

    //}
    //private void OnTriggerStay2D(Collider2D collision) {
    //    Debug.Log("trigger stay");

    //}
    //private void OnTriggerExit2D(Collider2D collision) {
    //    Debug.Log("trigger exit");

    //}
}