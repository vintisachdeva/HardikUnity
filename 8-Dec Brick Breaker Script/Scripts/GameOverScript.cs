using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

	//Collision or Trigger --> 

	public SceneManagerScript sceneManagerScript;

	void OnTriggerEnter2D(Collider2D collider){
		Destroy (collider.gameObject);
		sceneManagerScript.LoadGameScene ("Game Over");

	}
}
