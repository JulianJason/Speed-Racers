using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start () 
	{

		rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate ()
	{
		//float moveHorizontal = Input.GetAxis ("Horizontal2");
		float moveVertical = Input.GetAxis ("Vertical2");

		Vector3 movement = new Vector3 (0.0f , 0.0f , moveVertical);

		rb.AddForce (movement * speed); 
	}
}
