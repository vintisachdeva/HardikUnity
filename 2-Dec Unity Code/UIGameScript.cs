using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class UIGameScript : MonoBehaviour {

	int minimum = 1;   
	int maximum = 101;
	int value = 50;

	public Text userNumberText;

	void Start(){
		CalculateValue ();
	}

	public void Higher(){
		minimum = value;
		CalculateValue ();
	}


	public void Lower(){
		maximum = value;
		CalculateValue ();
	}

	public void Equal(){
		SceneManager.LoadScene ("Win");
	}

	void CalculateValue(){
		if (minimum == maximum) {
			value = Random.Range (1, 100);
		}else
		value = Random.Range (minimum, maximum);

		//value = (minimum + maximum) / 2; 
		userNumberText.text = value.ToString ();
	}
}