using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : MonoBehaviour {

	public static MobileInput INSTANCE {set; get;}

	private const float DEAD_ZONE = 100.0f;

	private bool TAP, SWIPE_LEFT, SWIPE_RIGHT, SWIPE_UP, SWIPE_DOWN;
	private Vector2 SWIPE_DELTA, START_TOUCH;

	public bool tap {get{return TAP;}}
	public Vector2 swipeDelta{get{return SWIPE_DELTA;}}
	public bool swipeLeft {get{return SWIPE_LEFT;}}
	public bool swipeRight {get{return SWIPE_RIGHT;}}
	public bool swipeUp {get{return SWIPE_UP;}}
	public bool swipeDown {get{return SWIPE_DOWN;}}

	private void Awake() {
		INSTANCE = this;
	}

	private void Update() {
		TAP = SWIPE_LEFT = SWIPE_RIGHT = SWIPE_DOWN = SWIPE_UP = false;

		#region Standalone Inputs
		if(Input.GetMouseButtonDown(0)) {
			TAP = true;
			START_TOUCH = Input.mousePosition;
		}
		else if(Input.GetMouseButtonUp(0)) {
			START_TOUCH = SWIPE_DELTA = Vector2.zero;
		}
		#endregion

		#region Mobile Inputs
		if(Input.touches.Length != 0) {
			if(Input.touches[0].phase == TouchPhase.Began) {
			TAP = true;
			START_TOUCH = Input.mousePosition;
			}
			else if(Input.touches[0].phase == TouchPhase.Ended 
					|| Input.touches[0].phase == TouchPhase.Canceled) {
				START_TOUCH = SWIPE_DELTA = Vector2.zero;
			}
		}
		#endregion
	
		SWIPE_DELTA = Vector2.zero;
		if(START_TOUCH != Vector2.zero) {
			if(Input.touches.Length != 0) {
				SWIPE_DELTA = Input.touches[0].position - START_TOUCH;
			}
			else if(Input.GetMouseButton(0)) {
				SWIPE_DELTA = (Vector2)Input.mousePosition - START_TOUCH;
			}
		}

		if(SWIPE_DELTA.magnitude > DEAD_ZONE) {
			float X = SWIPE_DELTA.x;
			float Y = SWIPE_DELTA.y;

			if(Mathf.Abs(X) > Mathf.Abs(Y)) {
				if (X < 0)
					SWIPE_LEFT = true;
				else
					SWIPE_RIGHT = true;
			}
			else {
				if (Y < 0)
					SWIPE_DOWN = true;
				else
					SWIPE_UP = true;
			}

			START_TOUCH = SWIPE_DELTA = Vector2.zero;
		}
	}
}
