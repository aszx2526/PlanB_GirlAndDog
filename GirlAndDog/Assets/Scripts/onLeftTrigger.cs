﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLeftTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(Input.GetAxis("LeftTrigger"));
    }
}
