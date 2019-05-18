using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    Rigidbody rb;
    Vector3 vel;
    public float speed;
    public Rigidbody rb2;
	void Start () {
        rb = GetComponent<Rigidbody>();
        vel = rb.velocity;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) {
            vel.z = speed * Time.deltaTime;
            rb.velocity = vel;
        } else if (Input.GetKey(KeyCode.S)) {
            vel.z = -speed * Time.deltaTime;
            rb.velocity = vel;
        } else if (Input.GetKey(KeyCode.A)) {
            vel.x = -speed * Time.deltaTime;
            rb.velocity = vel;
        } else if (Input.GetKey(KeyCode.D)) {
            vel.x = speed * Time.deltaTime;
            rb.velocity = vel;
        } else {
            vel.x = 0;
            vel.z = 0;
        }
    }
}
