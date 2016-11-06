using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilTankController : MonoBehaviour {

	float speedForce = 40f;
	float torqueForce = 15f;

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
