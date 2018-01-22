using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour {

	public Text scoreText;
	int coin = 0;
	public GameObject cabinet; 
	public static int totalCoins = 0;

	void Start(){
		scoreText.text = coin.ToString ();
		if (tag == "Coin") {
			totalCoins++;
		}
		print (totalCoins);
	}

	void OnTriggerEnter2D(Collider2D collider2D){
	
		if (collider2D.tag == "Player") {
			
			totalCoins--;
			coin++;
			print (coin);
			gameObject.SetActive (false);
			scoreText.text = coin.ToString ();
			GameOver ();
		}

	}
	private void GameOver(){
		if (totalCoins <= 0) {
			cabinet.SetActive (true);
		}
	}

}
