using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class BottomBrickScript : MonoBehaviour {

	//Vector2 --> 2 type arguments --> x-axis, y-axis
	//Vector3 --> 3 type arguments --> x-axis, y-axis, z-axis

	public float bottomBrickSpeed = 1.5f;

	private float minBoundary = -2.1f;

	private float maxBoundary = 2.1f;
	private Vector3 vector3 = new Vector3 (0, -4, 0);

	// Use this for initialization
	void Start () {

		//Vector3 vector3 = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		//classname objectName new keyword--> memory allocate to object, constructor

	}
	
	// Update is called once per frame
	void Update () {
		//Transform class

		float position = transform.position.x + (Input.GetAxis ("Horizontal") * bottomBrickSpeed); 

		vector3 = new Vector3(Mathf.Clamp (position , minBoundary, maxBoundary), -4, 0);
		transform.position = vector3;

	}
}