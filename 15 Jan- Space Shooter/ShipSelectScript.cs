using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipSelectScript : MonoBehaviour {

	public Sprite[] playerShips;
	public static Sprite selectedPlayerSprite;
	public int counter = 0;
	//private SpriteRenderer spriteRenderer;

	public Image playerSprite;

	void Start(){
		selectedPlayerSprite = playerSprite.sprite;
	}

	//public Image playerImage;
	public void NextShip(){
		if (counter < playerShips.Length-1) {
			counter++;
			playerSprite.sprite = playerShips [counter];
		} else {
			counter = 0;
		}

		selectedPlayerSprite = playerSprite.sprite;
	}

	public void PreviousShip(){
		if (counter < playerShips.Length-1) {
			counter--;
			playerSprite.sprite = playerShips [counter];
		} else {
			counter = 0;
		}
		selectedPlayerSprite = playerSprite.sprite;
	}
}