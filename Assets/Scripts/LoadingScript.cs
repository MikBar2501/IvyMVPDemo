using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour {

	public Transform LoadingBar;

	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	[SerializeField] Text Text1;

	void Start() {
	}

	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			Debug.Log ((int)currentAmount);
		} else {
				SceneManager.LoadScene("MainGame");
		}

		LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
	}
}
