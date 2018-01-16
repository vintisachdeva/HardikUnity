using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {

	public float moveSpeed;


	// Update is called once per frame
	void Update () {
		Vector2 vector2 = new Vector2 (Time.time * -moveSpeed, 0);
		GetComponent <Renderer>().material.mainTextureOffset = vector2;
	}
}



