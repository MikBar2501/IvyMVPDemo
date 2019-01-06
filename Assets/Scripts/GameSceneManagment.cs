using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManagment : MonoBehaviour {

	public PunktScript PUNKT_01;
	public PunktScript PUNKT_02;
	public PunktScript PUNKT_03;
	public PunktScript PUNKT_04;
	public PunktScript PUNKT_05;
	public PunktScript PUNKT_06;

	public GameManager GM;


	public void SceneManagmentLoad() 
	{
		GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		switch (GM.SAVESTATE)
      	{
          case 1:
            PUNKT_01.isAnswered = true;
			PUNKT_02.isAnswered = false;
			PUNKT_03.isAnswered = false;
			PUNKT_04.isAnswered = false;
			PUNKT_05.isAnswered = false;
			PUNKT_06.isAnswered = false;
			PUNKT_01.isActivated = true;
			PUNKT_02.isActivated = true;
			PUNKT_03.isActivated = false;
			PUNKT_04.isActivated = false;
			PUNKT_05.isActivated = false;
			PUNKT_06.isActivated = false;
			PUNKT_01.PunktLoad();
            break;

          case 2:
            PUNKT_01.isAnswered = true;
			PUNKT_02.isAnswered = true;
			PUNKT_03.isAnswered = false;
			PUNKT_04.isAnswered = false;
			PUNKT_05.isAnswered = false;
			PUNKT_06.isAnswered = false;
			PUNKT_01.isActivated = true;
			PUNKT_02.isActivated = true;
			PUNKT_03.isActivated = true;
			PUNKT_04.isActivated = false;
			PUNKT_05.isActivated = false;
			PUNKT_06.isActivated = false;
			PUNKT_01.PunktLoad();
			PUNKT_02.PunktLoad();
            break;
        
		  case 3:
            PUNKT_01.isAnswered = true;
			PUNKT_02.isAnswered = true;
			PUNKT_03.isAnswered = true;
			PUNKT_04.isAnswered = false;
			PUNKT_05.isAnswered = false;
			PUNKT_06.isAnswered = false;
			PUNKT_01.isActivated = true;
			PUNKT_02.isActivated = true;
			PUNKT_03.isActivated = true;
			PUNKT_04.isActivated = true;
			PUNKT_05.isActivated = false;
			PUNKT_06.isActivated = false;
			PUNKT_01.PunktLoad();
			PUNKT_02.PunktLoad();
			PUNKT_03.PunktLoad();
            break;

		  case 4:
            PUNKT_01.isAnswered = true;
			PUNKT_02.isAnswered = true;
			PUNKT_03.isAnswered = true;
			PUNKT_04.isAnswered = true;
			PUNKT_05.isAnswered = false;
			PUNKT_06.isAnswered = false;
			PUNKT_01.isActivated = true;
			PUNKT_02.isActivated = true;
			PUNKT_03.isActivated = true;
			PUNKT_04.isActivated = true;
			PUNKT_05.isActivated = true;
			PUNKT_06.isActivated = false;
			PUNKT_01.PunktLoad();
			PUNKT_02.PunktLoad();
			PUNKT_03.PunktLoad();
			PUNKT_04.PunktLoad();
            break;

		  case 5:
            PUNKT_01.isAnswered = true;
			PUNKT_02.isAnswered = true;
			PUNKT_03.isAnswered = true;
			PUNKT_04.isAnswered = true;
			PUNKT_05.isAnswered = true;
			PUNKT_06.isAnswered = false;
			PUNKT_01.isActivated = true;
			PUNKT_02.isActivated = true;
			PUNKT_03.isActivated = true;
			PUNKT_04.isActivated = true;
			PUNKT_05.isActivated = true;
			PUNKT_06.isActivated = true;
			PUNKT_01.PunktLoad();
			PUNKT_02.PunktLoad();
			PUNKT_03.PunktLoad();
			PUNKT_04.PunktLoad();
			PUNKT_05.PunktLoad();
            break;

		  case 6:
            PUNKT_01.isAnswered = true;
			PUNKT_02.isAnswered = true;
			PUNKT_03.isAnswered = true;
			PUNKT_04.isAnswered = true;
			PUNKT_05.isAnswered = true;
			PUNKT_06.isAnswered = true;
			PUNKT_01.isActivated = true;
			PUNKT_02.isActivated = true;
			PUNKT_03.isActivated = true;
			PUNKT_04.isActivated = true;
			PUNKT_05.isActivated = true;
			PUNKT_06.isActivated = true;
			PUNKT_01.PunktLoad();
			PUNKT_02.PunktLoad();
			PUNKT_03.PunktLoad();
			PUNKT_04.PunktLoad();
			PUNKT_05.PunktLoad();
			PUNKT_06.PunktLoad();
            break;

		  default:
            PUNKT_01.isAnswered = false;
			PUNKT_02.isAnswered = false;
			PUNKT_03.isAnswered = false;
			PUNKT_04.isAnswered = false;
			PUNKT_05.isAnswered = false;
			PUNKT_01.isActivated = true;
			PUNKT_02.isActivated = false;
			PUNKT_03.isActivated = false;
			PUNKT_04.isActivated = false;
			PUNKT_05.isActivated = false;
            break;
      	}
	}

	// Use this for initialization
	void Start () {
		
		
	}
}
