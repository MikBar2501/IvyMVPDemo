using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuSceneManagment : MonoBehaviour {


	public GameObject PROFILE;
	public GameObject MENU;
	public Text POINTS_TEKST;
	public GameManager GAMEMANAGER;

	void Start() {
		PROFILE.SetActive(false);
		MENU.SetActive(true);
		GAMEMANAGER = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		POINTS_TEKST.text = "Moje punkty: " + GAMEMANAGER.POINTS.ToString();

	}

	public void ProfileActive(bool activate) {
		if(activate) {
			PROFILE.SetActive(true);
			MENU.SetActive(false);
			POINTS_TEKST.text = "Moje punkty: " + GAMEMANAGER.POINTS.ToString();
		}
		else {
			PROFILE.SetActive(false);
			MENU.SetActive(true);
		}
	}

	public void ResetSave() {
		GAMEMANAGER.Reset();
	}

}
