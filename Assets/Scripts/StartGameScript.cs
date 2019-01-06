using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour {

	public GameObject CanvasGame;
	public GameObject CanvasMenu;

	public GameManager GM;
	public RandomTargetList targetList;

	void Start() {
		CanvasGame.SetActive(false);
		CanvasMenu.SetActive(true);
		GM.Load();
	}



	public void StartGame() {
		GetComponent<GameSceneManagment>().SceneManagmentLoad();
		CanvasGame.SetActive(true);
		CanvasMenu.SetActive(false);
		if(!GM.isChoose) {
			GM.whoseChoose = targetList.RandomTarget();
			GM.isChoose = true;
			targetList.SetTarget(GM.whoseChoose);
		} else {
			targetList.SetTarget(GM.whoseChoose);
		}
	}

	public void BackToMenu() {
		GetComponent<MenuSwipe>().MUSIC_ACTIVE = false;
		GetComponent<MenuSwipe>().MAP_ACTIVE = false;
		GetComponent<MenuSwipe>().ANIMATOR_MAP.SetBool("active",false);
		GetComponent<MenuSwipe>().ANIMATOR_MUSIC.SetBool("active",false);
		CanvasGame.SetActive(false);
		CanvasMenu.SetActive(true);
		GM.Save();
	}
	
}
