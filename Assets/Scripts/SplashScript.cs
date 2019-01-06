using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour {

	void Start() {
		StartCoroutine(Example());
	}

	IEnumerator Example() {
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene("Loading");
	}
}
