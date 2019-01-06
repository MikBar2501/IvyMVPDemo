using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch_Script : MonoBehaviour {


	Ray ray;
	RaycastHit hit;

	void Update () {
		/*#region Mobile Inputs
		if(Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
		{
			ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			if(Physics.Raycast(ray,out hit,Mathf.Infinity))
			{
				GameObject gm = GameObject.FindGameObjectWithTag("GameManager");
				//GameObject butter = GameObject.FindGameObjectWithTag("Butterfly_mat");


				//gm.GetComponent<GameMasterScript>().butterflyIsTaped = true;
				//butter.GetComponent<MeshRenderer>().materials[0].SetColor("_Color", Color.red);

				if(hit.collider.tag == "Plane")
				{
					QA.GetComponent<Animator>().SetBool("quest", true);
					//gm.GetComponent<GameMasterScript>().butterflyAnswer = true;
				}
			}
		}
		#endregion*/

		#region Standalone Inputs
		if(Input.GetMouseButtonDown(0))
		{
			Vector3 mousePosFar = new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.farClipPlane);
			Vector3 mousePosNear = new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.nearClipPlane);
			Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
			Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);
			//Debug.DrawRay(mousePosN,mousePosF-mousePosN, Color.green);

			RaycastHit hit;

			if (Physics.Raycast(mousePosN, mousePosF-mousePosN, out hit))
			{
				if(hit.collider.tag == "AR_Object")
				{
					if(!hit.collider.GetComponent<PunktScript>().isAnswered && hit.collider.GetComponent<PunktScript>().isActivated) {
						hit.collider.GetComponent<PunktScript>().StarQuestion();
					}
				}
			}
		}
		#endregion
	}
}
