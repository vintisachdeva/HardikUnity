using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text scoreText;

	int score = 0;

	public void ScoreUpdate(int value){
		score += value;
		scoreText.text ="Score: " + score.ToString ();
	}

}
