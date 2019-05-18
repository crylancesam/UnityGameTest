using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    // Use this for initialization
    public Transform player;
    public float offset;
    Vector3 pos;
	void Start () {
        pos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        pos.z = player.transform.position.z + offset;
        transform.position = pos;
	}
}
