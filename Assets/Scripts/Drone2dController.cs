﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone2dController : MonoBehaviour {

	float speedForce = 13f;
	float torqueForce = 6f;

	public Transform firePoint;
	public GameObject Bullet;

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

			if(Input.GetButton("XButton"))
			{
				Instantiate(Bullet, firePoint.position, firePoint.rotation);
			}
		}

		rb.AddTorque( Input.GetAxis("LeftJoystickHorizontal") * torqueForce );
	}
}
