using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PunktScript : MonoBehaviour {

	public GameManager GM;
	public GameObject QA;
	public AudiobookScript audioBooks;
	public GameObject button_A;
	public GameObject button_B;
	public GameObject button_C;
	public GameObject button_D;
	public Text answer_A;
	public Text answer_B;
	public Text answer_C;
	public Text answer_D;
	public Text question;

	public string text_answer_A;
	public string text_answer_B;
	public string text_answer_C;
	public string text_answer_D;
	public string text_question;

	public int correct_answer;
	public int question_number;
	public AudioClip punkt_Clip;
	public bool isAnswered;
	public bool isActivated;
	public GameObject nextQuest;
	public GameSceneManagment GSM;
	public EndGameScript endGameScript;

	void Start () {
		GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		GSM = GameObject.FindGameObjectWithTag("GSM").GetComponent<GameSceneManagment>();
	}

	public void PunktLoad() 
	{
		if(question_number == 1 && GM.QUESTION_01 == true) {
			if(audioBooks.CLIP_NAMES[0] == null) {
				audioBooks.CLIP_NAMES[0] = punkt_Clip;
			} else {
				audioBooks.CLIP_NAMES.Add(punkt_Clip);
			}
				
		}

		if(question_number == 2 && GM.QUESTION_02 == true) {
			if(audioBooks.CLIP_NAMES[0] == null) {
				audioBooks.CLIP_NAMES[0] = punkt_Clip;
			} else {
				audioBooks.CLIP_NAMES.Add(punkt_Clip);
			}	
		}

		if(question_number == 3 && GM.QUESTION_03 == true) {
			if(audioBooks.CLIP_NAMES[0] == null) {
				audioBooks.CLIP_NAMES[0] = punkt_Clip;
			} else {
				audioBooks.CLIP_NAMES.Add(punkt_Clip);
			}	
		}

		if(question_number == 4 && GM.QUESTION_04 == true) {
			if(audioBooks.CLIP_NAMES[0] == null) {
				audioBooks.CLIP_NAMES[0] = punkt_Clip;
			} else {
				audioBooks.CLIP_NAMES.Add(punkt_Clip);
			}	
		}

		if(question_number == 5 && GM.QUESTION_05 == true) {
			if(audioBooks.CLIP_NAMES[0] == null) {
				audioBooks.CLIP_NAMES[0] = punkt_Clip;
			} else {
				audioBooks.CLIP_NAMES.Add(punkt_Clip);
			}		
		}

		if(question_number == 6 && GM.QUESTION_06 == true) {
			if(audioBooks.CLIP_NAMES[0] == null) {
				audioBooks.CLIP_NAMES[0] = punkt_Clip;
			} else {
				audioBooks.CLIP_NAMES.Add(punkt_Clip);
			}		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StarQuestion() {
		QA.SetActive(true);
		QA.GetComponent<Answers_Script>().ShowAgain();
		QA.GetComponent<Answers_Script>().Object_number = this.gameObject;
		answer_A.text = text_answer_A;
		answer_B.text = text_answer_B;
		answer_C.text = text_answer_C;
		answer_D.text = text_answer_D;
		question.text = text_question;
	}

	public void EndQuestion() {

		StartCoroutine(WaitAMoment());
		
	}

	public bool CheckTheQuestion(int answer)
	{
		if(answer == correct_answer) {
			EndQuestion();
			isAnswered = true;
			//GM.SAVESTATE += 1;
			GM.POINTS += 10;
			if(nextQuest != null) {
				nextQuest.GetComponent<PunktScript>().isActivated = true;
			}
			
			if(audioBooks.CLIP_NAMES[0] == null) {
				audioBooks.CLIP_NAMES[0] = punkt_Clip;
				audioBooks.AddTitle();
			} else {
				audioBooks.CLIP_NAMES.Add(punkt_Clip);
			}
			audioBooks.CLIP_NAMES.OrderBy(n => n);
			if(question_number == 1) {
				GM.QUESTION_01 = true;
				GM.SAVESTATE = 1;
			}
			if(question_number == 2) {
				GM.QUESTION_02 = true;
				GM.SAVESTATE = 2;
			}
			if(question_number == 3) {
				GM.QUESTION_03 = true;
				GM.SAVESTATE = 3;
			}
			if(question_number == 4) {
				GM.QUESTION_04 = true;
				GM.SAVESTATE = 4;
			}
			if(question_number == 5) {
				GM.QUESTION_05 = true;
				GM.SAVESTATE = 5;
			}
			if(question_number == 6) {
				GM.QUESTION_06 = true;
				GM.SAVESTATE = 6;
				endGameScript.SetThanks();
			}
			GM.Save();
			return true;
		} else {
			GM.POINTS -= 10;
			return false;;
		}
		
	}

	IEnumerator WaitAMoment() {
		yield return new WaitForSeconds(3);
		QA.SetActive(false);
	}
}
