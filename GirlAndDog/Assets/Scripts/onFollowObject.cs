using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFollowObject : MonoBehaviour {
    public GameObject[] myTarget;
    public int myWatchMod;
    public float myFollowSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, myTarget[myWatchMod].transform.position, Time.deltaTime * myFollowSpeed);
        if (Input.GetButton("LB")) { myWatchMod = 0; }
        if (Input.GetButton("RB")) { myWatchMod = 1; }
    }
}
