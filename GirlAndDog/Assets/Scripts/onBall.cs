using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBall : MonoBehaviour {
    public float myForce;
    public GameObject myFollowObject;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward*myForce);
	}
	
	// Update is called once per frame
	void Update () {
        if (myFollowObject) {
            transform.position = myFollowObject.transform.position;
        }
	}
}
