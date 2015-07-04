using UnityEngine;
using System.Collections;

public class RadHintenScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
		this.myRadius = GetComponent<SphereCollider>().radius;
		this.speed = 50 * this.myRadius;
		
		// TODO calculate transmission based on radi
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public float mAcceleration;
	private float speed;
	private float myRadius;
	
	public float getRadius()
	{
		return (this.myRadius);
	}
	
	/*
	void FixedUpdate ()
	{
		float v = Input.GetAxis("Horizontal") * Time.deltaTime;
		
		this.applyRotation (-v, this.speed);
		GameObject go = GameObject.Find ("RadVorne");
		RadVorneScript otherScript = go.GetComponent<RadVorneScript>();
		otherScript.applyRotation(-v, speed);
	} */
	
	public void applyRotation (float rot, float withSpeed)
	{
		GetComponent<Rigidbody>().AddTorque(transform.forward * mAcceleration * rot * withSpeed);
	}
}
