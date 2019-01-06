using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTargetList : MonoBehaviour {

	public GameManager gm;
	public FileMapMenuScript fMMS;
	public Sprite [] firtstTargetFoto;
	public Sprite [] firtstTargetFotoFrag;
	public Sprite [] secondTargetFoto;
	public Sprite [] secondTargetFotoFrag;
	public Button [] fragments;

	void Start() {
		fMMS = GetComponent<FileMapMenuScript>();
	}

	public void SetTarget(int whose) {
		if(whose == 0) {
			for(int i=0; i<fragments.Length; i++) {
				fragments[i].GetComponent<Image>().sprite = firtstTargetFotoFrag[i];
				
			}
			fMMS.FOTO_FRAGMENTS = firtstTargetFoto;
		} else {
			for(int i=0; i<fragments.Length; i++) {
				fragments[i].GetComponent<Image>().sprite = secondTargetFotoFrag[i];
				
			}
			fMMS.FOTO_FRAGMENTS = secondTargetFoto;
		}
	}

	public int RandomTarget() {
			int target = UnityEngine.Random.Range(0,10);
			target = target % 2;
			return target;
	}
}
