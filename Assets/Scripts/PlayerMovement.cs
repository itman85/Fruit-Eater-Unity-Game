using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private float speed = 8f;
	private Rigidbody2D myBody;

	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();

	}

	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		//print ("The value is " + Input.GetAxis ("Horizontal"));
	}
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 vel = myBody.velocity;
		vel.x = Input.GetAxis ("Mouse X") * speed;
		myBody.velocity = vel;

	}
	
}
