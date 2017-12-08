using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBallScript : MonoBehaviour {

	public BottomBrickScript bridgeBrick;

	private bool launched = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (!launched) {
			this.transform.position = new Vector2 (bridgeBrick.transform.position.x, transform.position.y);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			launched = true;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 8f);
		}
	}
}
