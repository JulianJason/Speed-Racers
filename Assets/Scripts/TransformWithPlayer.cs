using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformWithPlayer : MonoBehaviour {

	public Transform Obj;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (Obj.position.x, Obj.position.y + 1.5f, Obj.position.z);
	
	}

}
