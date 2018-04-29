using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	// Use this for initialization
	Rigidbody rigidbody;
	float speed = 10.0f;
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(isLocalPlayer);
		if(isLocalPlayer){
			move();
		 }
	}

	void move () {
		float horizontalSpeed = Input.GetAxis("Horizontal")* speed;
		float verticalSpeed = Input.GetAxis("Vertical")* speed;
		rigidbody.velocity = new Vector3(horizontalSpeed,0,verticalSpeed);
		Debug.Log(rigidbody.velocity);
	}
}
