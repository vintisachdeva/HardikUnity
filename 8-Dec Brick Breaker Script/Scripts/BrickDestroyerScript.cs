using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestroyerScript : MonoBehaviour {

	public ScoreScript scoreScript;

	void OnCollisionEnter2D(Collision2D collision2D){
		Destroy (gameObject);
		scoreScript.ScoreUpdate (10);
	}
}