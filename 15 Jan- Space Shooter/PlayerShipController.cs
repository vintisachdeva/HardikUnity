using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerShipController : MonoBehaviour {

	public float moveSpeed  =5.0f;
	public float drag = 0.5f;
	public float terminalRotationSpeed = 25.0f;
	public Vector2 MoveVector{ set; get;}

	public JoystickScript joyStickScript;

	public JoystickScript rotationJoyStick;

	private Rigidbody2D thisRigidBody2D;

	// Use this for initialization
	void Start () {
		//GetComponent<SpriteRenderer> ().sprite  = ShipSelectScript.selectedPlayerSprite;
		thisRigidBody2D = GetComponent <Rigidbody2D> ();
		//thisRigidBody2D.velocity = terminalRotationSpeed;
		thisRigidBody2D.drag = drag;
	}
	
	// Update is called once per frame
	void Update () {
		MoveVector = PoolInput();

		Move ();
		PoolRotation ();
	}

	private void Move(){
		thisRigidBody2D.AddForce ((MoveVector * moveSpeed));
	}

	private Vector3 PoolInput(){
		Vector3 dir = Vector3.zero;
		dir.x = joyStickScript.Horizontal ();
		dir.y = joyStickScript.Vertical ();

		if (dir.magnitude > 1)
			dir.Normalize ();

		return dir;
	}

	private void PoolRotation(){
		transform.Rotate (new Vector3(transform.rotation.x, transform.rotation.y,moveSpeed * rotationJoyStick.RotateObject ()));
	}

}