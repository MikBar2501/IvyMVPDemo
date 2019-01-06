using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBehaviour : MonoBehaviour {

	//Canvasy
	public GameObject canvasMenu;
	public GameObject canvasGame;
	//Game Panels
	public GameObject musicPanel;
	public GameObject folderPanel;
	public GameObject gamePanel;
	//Camery
	public GameObject cameraAR;
	public GameObject cameraNormal;
	//Menu Panels
	public GameObject profilePanel;
	public GameObject menuPanel;
	public Text pointsText;
	bool musicIsActive = false;
	bool gameIsActive = false;
	public GameManager gM;
	public RandomTargetList targetList;
	public EndGameScript endGameScript;
	public FileMapMenuScript fileMapMenuScript;

	void Start() {
		gM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		targetList = GetComponent<RandomTargetList>();
		endGameScript = GetComponent<EndGameScript>();
		fileMapMenuScript = GetComponent<FileMapMenuScript>();
		gM.Load();
		musicIsActive = false;
		pointsText.text = "Moje punkty: " + gM.POINTS.ToString();
		cameraNormal.SetActive(true);
		cameraAR.SetActive(false);
		canvasMenu.SetActive(true);
		canvasGame.SetActive(false);
		profilePanel.SetActive(false);
		menuPanel.SetActive(true);
	}

	public void ProfileActive(bool activate) {
		if(activate) {
			profilePanel.SetActive(true);
			menuPanel.SetActive(false);
			pointsText.text = "Moje punkty: " + gM.POINTS.ToString();
		}
		else {
			profilePanel.SetActive(false);
			menuPanel.SetActive(true);
		}
	}

	public void ResetSave() {
		gM.Reset();
		pointsText.text = "Moje punkty: " + gM.POINTS.ToString();
		endGameScript.SetMap();
	}

	public void StartGame() {
		GetComponent<GameSceneManagment>().SceneManagmentLoad();
		canvasGame.SetActive(true);
		canvasMenu.SetActive(false);
		if(!gM.isChoose) {
			gM.whoseChoose = targetList.RandomTarget();
			gM.isChoose = true;
			targetList.SetTarget(gM.whoseChoose);
		} else {
			targetList.SetTarget(gM.whoseChoose);
		}
		endGameScript.StartMethod();

	}

	public void BackToMenu() {
		//GetComponent<MenuSwipe>().MUSIC_ACTIVE = false;
		//GetComponent<MenuSwipe>().ANIMATOR_MUSIC.SetBool("active",false);
		fileMapMenuScript.MAP_ACTIVE = true;
		fileMapMenuScript.changeFile();
		fileMapMenuScript.MAP_ACTIVE = false;
		musicIsActive = true;
		MusicPanelSwitch();
		canvasGame.SetActive(false);
		canvasMenu.SetActive(true);
		gM.Save();
	}

	public void MusicPanelSwitch() {
		musicIsActive = !musicIsActive;
		musicPanel.GetComponent<Animator>().SetBool("active",musicIsActive);
	}

	public void GamePanelSwitch() {
		musicIsActive = true;
		MusicPanelSwitch();
		gameIsActive = !gameIsActive;
		cameraAR.SetActive(gameIsActive);
		cameraNormal.SetActive(!gameIsActive);
		gamePanel.SetActive(gameIsActive);
		folderPanel.SetActive(!gameIsActive);

	}


}
