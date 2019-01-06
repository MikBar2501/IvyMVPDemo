using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScript : MonoBehaviour {

	public Image mapImage;
	public GameManager gameManager;

	public Sprite map;
	public Sprite end;

	public GameObject mapObject;
	public GameObject thanksObject;

	// Use this for initialization
	public void StartMethod() {
		if(gameManager.SAVESTATE >= 6) {
			SetThanks();
		} else {
			SetMap();
		}	
	}

	public void SetThanks() {
		thanksObject.SetActive(true);
		mapObject.SetActive(false);
	}

	public void SetMap() {
		thanksObject.SetActive(false);
		mapObject.SetActive(true);
	}
}
