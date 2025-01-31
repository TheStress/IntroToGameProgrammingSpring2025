using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demonstration : MonoBehaviour {

    private void Start() {
        float number = 0;

        if(transform.position.y > 7) {
            Vector3 test = new Vector3(transform.position.x, -6.62f, transform.position.z);
            transform.position = test;
        }
    }


    // Update is called once per frame
    void Update() {

    }
}
