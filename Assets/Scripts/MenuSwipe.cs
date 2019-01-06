using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwipe : MonoBehaviour {

public Animator ANIMATOR_MAP;
public Animator ANIMATOR_MUSIC;

public bool MUSIC_ACTIVE;
public bool MAP_ACTIVE;
	

	private void Start() {
		MUSIC_ACTIVE = false;
		MAP_ACTIVE = false;
	}

	private void Update() {
		if(MobileInput.INSTANCE.swipeUp) {
			if(!MUSIC_ACTIVE && !MAP_ACTIVE) {
				MAP_ACTIVE = true;
				GetComponent<FileMapMenuScript>().SetMap();
				ANIMATOR_MAP.SetBool("active",MAP_ACTIVE);
			}

			if(MUSIC_ACTIVE && !MAP_ACTIVE) {
				MUSIC_ACTIVE = false;
				ANIMATOR_MUSIC.SetBool("active",MUSIC_ACTIVE);
			}

			if(!MUSIC_ACTIVE && MAP_ACTIVE) {

			}
		}



		if(MobileInput.INSTANCE.swipeDown) {
			if(!MUSIC_ACTIVE && !MAP_ACTIVE) {
				MUSIC_ACTIVE = true;
				ANIMATOR_MUSIC.SetBool("active",MUSIC_ACTIVE);
			}

			if(!MUSIC_ACTIVE && MAP_ACTIVE) {
				MAP_ACTIVE = false;
				ANIMATOR_MAP.SetBool("active",MAP_ACTIVE);
				//GetComponent<FileMapMenuScript>().SetMap();
			}
		
		}
	}
}
