using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerRun : MonoBehaviour {

	public ParticleSystem particle;
	public Button replayButton;

	Animator animator;

	public float speed =  1f;

	bool isMovingRight = true;
	bool isFlipped = false;

	void Start(){
		animator = GetComponent<Animator> ();

	}

	void Update(){
		
		if (isMovingRight) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			} else {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		}
		GetComponent <SpriteRenderer>().flipX = isFlipped;
	}

	void OnCollisionEnter2D(Collision2D collision2D){

		if (collision2D.gameObject.tag == "Boundary") {

			isMovingRight = !isMovingRight;
			isFlipped = !isFlipped;
		}

		if (collision2D.gameObject.tag == "Hurdle") {
			//animator.SetTrigger ("playerDead");
			particle.transform.position = transform.position;
			Destroy (gameObject);
			particle.Play (); 
			replayButton.gameObject.SetActive (true);
			//SceneManager.LoadScene (SceneManager.GetActiveScene ());
		}
	}
}