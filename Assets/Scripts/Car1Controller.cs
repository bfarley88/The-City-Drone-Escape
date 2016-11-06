using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1Controller : MonoBehaviour {

	float speedForce = 32f;
	float torqueForce = 1.7f;

	// Use this for initialization
	void Start () {

	}

	void Update() {
		// check for button up down here
	}

	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		if(Input.GetButton("AButton")) {
			rb.AddForce( transform.up * speedForce );
		}

		rb.AddTorque( Input.GetAxis("LeftJoystickHorizontal") * torqueForce );
	}
}
