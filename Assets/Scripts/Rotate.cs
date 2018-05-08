using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    Transform bolt;

    // Use this for initialization
    void Start () {
        bolt = GameObject.FindGameObjectWithTag("Pivot").transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(bolt.position, Vector3.forward, 15f);
    }
}
