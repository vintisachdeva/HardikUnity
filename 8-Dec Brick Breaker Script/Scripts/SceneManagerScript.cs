using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneManagerScript : MonoBehaviour {

	public void LoadGameScene(String name){
		SceneManager.LoadScene (name);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}