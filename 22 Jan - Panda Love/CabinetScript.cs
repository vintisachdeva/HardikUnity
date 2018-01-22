using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CabinetScript : MonoBehaviour {

	private static int counter = 2;
	public Text levelText;

	void OnCollisionEnter2D(Collision2D collision2D){
		if (collision2D.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Level "+counter);
			levelText.text ="Level "+ counter;
			counter++;
			CoinCollector.totalCoins = 0;
		}

	}

}
