using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers_Script : MonoBehaviour {

	public GameObject button_A;
	public GameObject button_B;
	public GameObject button_C;
	public GameObject button_D;

	public GameObject Object_number;


	// Use this for initialization
	
	public void Answer(int answ)
	{
		if(answ == 1)
		{
			//button_A.SetActive(false);
			if(Object_number.GetComponent<PunktScript>().CheckTheQuestion(1)) {
				button_A.GetComponent<Image>().color = new Color(0f,255f,0f,127f);
			}
			else {
				button_A.GetComponent<Image>().color = new Color(255f,0f,0f,127f);
			}
			
		}
		else if(answ == 2)
		{
			//button_B.SetActive(false);
			//Object_number.GetComponent<PunktScript>().CheckTheQuestion(2);
			if(Object_number.GetComponent<PunktScript>().CheckTheQuestion(2)) {
				button_B.GetComponent<Image>().color = new Color(0f,255f,0f,127f);
			}
			else {
				button_B.GetComponent<Image>().color = new Color(255f,0f,0f,127f);
			}
		}
		else if(answ == 3)
		{
			//button_C.SetActive(false);
			//Object_number.GetComponent<PunktScript>().CheckTheQuestion(3);
			if(Object_number.GetComponent<PunktScript>().CheckTheQuestion(3)) {
				button_C.GetComponent<Image>().color = new Color(0f,255f,0f,127f);
			}
			else {
				button_C.GetComponent<Image>().color = new Color(255f,0f,0f,127f);
			}
		}
		else if(answ == 4)
		{
			//button_D.SetActive(false);
			//Object_number.GetComponent<PunktScript>().CheckTheQuestion(4);
			if(Object_number.GetComponent<PunktScript>().CheckTheQuestion(4)) {
				button_D.GetComponent<Image>().color = new Color(0f,255f,0f,127f);
			}
			else {
				button_D.GetComponent<Image>().color = new Color(255f,0f,0f,127f);
			}
		}
	}

	public void ShowAgain() {
		button_A.SetActive(true);
		button_B.SetActive(true);
		button_C.SetActive(true);
		button_D.SetActive(true);
	}

}
