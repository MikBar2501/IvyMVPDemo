using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//Authors:
	//Rose model: aneeshaynee - https://sketchfab.com/models/b413d7b8d30d43d182bf92501bb7fffe#download
	//Revolver model: Nicolas Gerard - https://sketchfab.com/models/130b638be70948dcb7cc18ce5a78bf97
	//Textures: <a href="https://www.freepik.com/free-photo/leather-macro-shot_1161875.htm">Designed by Nikitabuida</a>
	//<a target="_blank" href="https://www.Vecteezy.com">Free Vector Art by www.Vecteezy.com</a>

	public bool QUESTION_01;
	public bool QUESTION_02;
	public bool QUESTION_03;
	public bool QUESTION_04;
	public bool QUESTION_05;
	public bool QUESTION_06;
	public bool isChoose;
	public int whoseChoose;
	public int POINTS;
	public int SAVESTATE;

	
	void Awake()
	{
		GameObject[] OBJS = GameObject.FindGameObjectsWithTag("GameManager");
		if(OBJS.Length > 1)
		{
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject);
	}

	void Start() {
		Load();
	}

	public void Save() {
		if(QUESTION_06 == true) {
			SAVESTATE = 6;
		} else if(QUESTION_05 == true) {
			SAVESTATE = 5;
		} else if(QUESTION_04 == true) {
			SAVESTATE = 4;
		} else if(QUESTION_03 == true) {
			SAVESTATE = 3;
		} else if(QUESTION_02 == true) {
			SAVESTATE = 2;
		} else if(QUESTION_01 == true) {
			SAVESTATE = 1;
		} else {
			SAVESTATE = 0;
		}
		if(isChoose) {
			PlayerPrefs.SetInt("isChoose", 0);
		} else {
			PlayerPrefs.SetInt("isChoose", 1);
		}
		PlayerPrefs.SetInt("whoseChoose", whoseChoose);
		PlayerPrefs.SetInt("SaveState", SAVESTATE);
		PlayerPrefs.SetInt("Points", POINTS);
		Debug.Log("Zapisałem");

	}

	public void Load() {
		
		SAVESTATE = PlayerPrefs.GetInt("SaveState");
		POINTS = PlayerPrefs.GetInt("Points");
		if(PlayerPrefs.GetInt("isChoose") == 0) {
			isChoose = true;
		} else {
			isChoose = false;
		}
		whoseChoose = PlayerPrefs.GetInt("whoseChoose");
		switch (SAVESTATE)
      	{
          case 1:
            QUESTION_01 = true;
			QUESTION_02 = false;
			QUESTION_03 = false;
			QUESTION_04 = false;
			QUESTION_05 = false;
			QUESTION_06 = false;
            break;

          case 2:
            QUESTION_01 = true;
			QUESTION_02 = true;
			QUESTION_03 = false;
			QUESTION_04 = false;
			QUESTION_05 = false;
			QUESTION_06 = false;
            break;
        
		  case 3:
            QUESTION_01 = true;
			QUESTION_02 = true;
			QUESTION_03 = true;
			QUESTION_04 = false;
			QUESTION_05 = false;
			QUESTION_06 = false;
            break;

		  case 4:
            QUESTION_01 = true;
			QUESTION_02 = true;
			QUESTION_03 = true;
			QUESTION_04 = true;
			QUESTION_05 = false;
			QUESTION_06 = false;
            break;

		  case 5:
            QUESTION_01 = true;
			QUESTION_02 = true;
			QUESTION_03 = true;
			QUESTION_04 = true;
			QUESTION_05 = true;
			QUESTION_06 = false;
            break;

		  case 6:
            QUESTION_01 = true;
			QUESTION_02 = true;
			QUESTION_03 = true;
			QUESTION_04 = true;
			QUESTION_05 = true;
			QUESTION_06 = true;
            break;

		  default:
            QUESTION_01 = false;
			QUESTION_02 = false;
			QUESTION_03 = false;
			QUESTION_04 = false;
			QUESTION_05 = false;
			QUESTION_06 = false;
            break;
      	}
		  Debug.Log("Wczytałem");
		  Debug.Log("Target: " + whoseChoose);

	}

	public void Reset() {
		PlayerPrefs.SetInt("SaveState", SAVESTATE);
		PlayerPrefs.SetInt("Points", POINTS);
		QUESTION_01 = false;
		QUESTION_02 = false;
		QUESTION_03 = false;
		QUESTION_04 = false;
		QUESTION_05 = false;
		QUESTION_06 = false;
		isChoose = false;
		SAVESTATE = 0;
		POINTS = 0;
		Save();
	}
}
