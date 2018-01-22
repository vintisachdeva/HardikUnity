using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Experimental.UIElements;

public class SceneManagerScript : MonoBehaviour {

	public Button replayButton;

	public void LoadGameScene(String name){
		SceneManager.LoadScene (name);
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void LoadSceneAgain(){
		String name = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (name);
		CoinCollector.totalCoins = 0;
	}

}
