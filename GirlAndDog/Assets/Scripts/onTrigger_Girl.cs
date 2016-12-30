using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger_Girl : MonoBehaviour {
    public GameObject ball;
    public GameObject myFirePoint;
    public int myBallAmount;
    public bool isHaveBall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (myBallAmount > 0) {
            if (Input.GetAxis("RightTrigger") > 0.5)
            {
                GameObject myBall = Instantiate(ball, myFirePoint.transform.position, myFirePoint.transform.rotation) as GameObject;
                myBall.GetComponent<onBall>().myForce = 500;
                myBallAmount--;
            }
        }

        
    }
    void OnTriggerEnter(Collider other) {
        if (other.tag == "ball") {
          //  isHaveBall = true;
            myBallAmount++;
            Destroy(other.gameObject);
        }
    }
}
