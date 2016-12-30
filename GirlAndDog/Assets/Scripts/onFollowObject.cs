using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFollowObject : MonoBehaviour {
    public GameObject myTarget;
    public float myFollowSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, myTarget.transform.position, Time.deltaTime * myFollowSpeed);
	}
}
