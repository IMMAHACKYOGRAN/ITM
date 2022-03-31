using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        
    }

    void fixedUpdate() {
        if (Input.GetKeyDown(KeyCode.W)) {
            rb.AddForce(0, 0, speed, ForceMode.Impulse);

        }
    }
}
