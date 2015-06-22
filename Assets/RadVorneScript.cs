﻿using UnityEngine;
using System.Collections;

public class RadVorneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.myRadius = GetComponent<SphereCollider>().radius;

		this.speed = 25 * this.myRadius;

		// TODO calculate transmission based on radi
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private float speed;
	private float myRadius;

	public float getRadius()
	{
		return (this.myRadius);
	}
	
	
	void FixedUpdate ()
	{
		float v = Input.GetAxis("Horizontal") * Time.deltaTime;
		
		this.applyRotation (-v, this.speed);
		GameObject go = GameObject.Find ("RadHinten");
		RadHintenScript otherScript = go.GetComponent<RadHintenScript>();
		otherScript.applyRotation(-v, speed);
	}
	
	public void applyRotation (float rot, float withSpeed)
	{
		GetComponent<Rigidbody>().AddTorque(transform.forward * rot * withSpeed);
	}
}