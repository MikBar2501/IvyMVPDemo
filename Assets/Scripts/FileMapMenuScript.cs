using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileMapMenuScript : MonoBehaviour {

	public GameObject MAP_OBJECT;
	public GameObject FOTO_OBJECT;
	public GameObject FOTOGRPHIC;
	public GameObject MAP;

	public GameObject [] FRAGMENTS_BUTTON;
	public GameManager GM;

	public Sprite [] MAP_FRAGMENTS;
	public Sprite [] FOTO_FRAGMENTS;
	public bool MAP_ACTIVE;
	public Button changeButton;
	public Sprite fileSprite;
	public Sprite mapSprite;


	public void changeFile() {
		if(MAP_ACTIVE) {
			MAP_OBJECT.SetActive(true);
			FOTO_OBJECT.SetActive(false);
			changeButton.GetComponent<Image>().sprite = fileSprite;
		} else {
			MAP_OBJECT.SetActive(false);
			FOTO_OBJECT.SetActive(true);
			changeButton.GetComponent<Image>().sprite = mapSprite;
		}

		for(int i = 0; i < FRAGMENTS_BUTTON.Length; i++) {
			FRAGMENTS_BUTTON[i].SetActive(false);
		}
		
		if(GM.SAVESTATE > 0) {
			for(int i = 0; i < GM.SAVESTATE; i++) {
			if(i > 4) {
				break;
			}
			FRAGMENTS_BUTTON[i].SetActive(true);
			}
		}
		if(GM.SAVESTATE < 5) {
			FOTOGRPHIC.GetComponent<Image>().sprite = FOTO_FRAGMENTS[GM.SAVESTATE];
		}
		else {
			FOTOGRPHIC.GetComponent<Image>().sprite = FOTO_FRAGMENTS[5];
		}
		MAP_ACTIVE = !MAP_ACTIVE;
		
	}

	public void Start() {
		GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		MAP_OBJECT.SetActive(true);
		FOTO_OBJECT.SetActive(false);
		MAP_ACTIVE = false;
	}

	public void SetMap() {
		MAP_OBJECT.SetActive(true);
		FOTO_OBJECT.SetActive(false);
	}

	public void ButtonFoto(int i) {
		MAP.GetComponent<Image>().sprite = MAP_FRAGMENTS[i];
		FOTOGRPHIC.GetComponent<Animator>().Play("Foto_Faded");

	}
}
