using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerJump : MonoBehaviour {

	private float jumpForce = 7f, forwardForce = 0f;
	private Rigidbody2D myBody;
	private bool canJump;
	private Button jumpButton;

	private void Awake()
	{
		myBody = GetComponent<Rigidbody2D>();

		jumpButton = GameObject.Find("JumpButton").GetComponent<Button>();
		jumpButton.onClick.AddListener(() => Jump());
	}

	// Update is called once per frame
	void Update () {
	/*	if (Mathf.Abs(myBody.velocity.y) == 0)
		{
			canJump = true;
		} */
	}

	private void Jump()
	{
	/*	if (canJump)
		{
			canJump = false;
//			AudioSource.PlayClipAtPoint(jumpClip, transform.position);
		}

*/
		if(transform.position.x < 0)
		{
			forwardForce = 0.2f;
		}
		else
		{
			forwardForce = 0f;
		}

		myBody.velocity = new Vector2(forwardForce, jumpForce);
	}
}