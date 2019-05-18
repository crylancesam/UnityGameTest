using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    MeshRenderer playerMr;
    GameObject child;
    MeshRenderer rn;
    public Color[] color;
    int numColor = 0;
	void Start () {
        child = transform.GetChild(0).gameObject;
        rn = GetComponent<MeshRenderer>();
        playerMr = GameObject.FindGameObjectWithTag("Player").GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision col) {
        // change color
        if (numColor >= color.Length) numColor = 0;
        rn.material.color = color[numColor];
        numColor++;

        // pass color to player
        playerMr.material.color = rn.material.color;

        // update active
        bool status = child.activeSelf;
        child.SetActive(!status);
    }
}
