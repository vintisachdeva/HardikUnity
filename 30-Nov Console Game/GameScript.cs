using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

	int minimum = 1;   
	int maximum = 100;
	int value = 0;

	// Use this for initialization
	void Start () {
		print ("Welcome in this Console Game");
		print ("Choose a number between 1-100");
		print ("Press C if you picked a number"); 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			CalculateValue ();
		} 
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			minimum = value;
			CalculateValue ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			maximum = value;
			CalculateValue ();
		} else if(Input.GetKeyDown (KeyCode.Y)){
			print ("Guessed it Right!!!");
		}
	}

	void CalculateValue(){
		value = (minimum + maximum) / 2;// 50 
		print ("Do you choose " + value + "?");
		print ("Press UpArrow = Higher, Press DownArrow = Lower, Press Y = Equal");
	}
}