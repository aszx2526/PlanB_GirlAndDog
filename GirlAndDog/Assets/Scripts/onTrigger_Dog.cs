using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger_Dog : MonoBehaviour {
    public GameObject myMouthPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other) {
        if (other.tag == "ball") {
            other.GetComponent<onBall>().myFollowObject = myMouthPoint;
            //other.transform.position = myMouthPoint.transform.position;
        }
    }
}
