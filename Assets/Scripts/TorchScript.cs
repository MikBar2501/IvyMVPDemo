using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class TorchScript : MonoBehaviour {

	bool lamp = true;

	public void SetTorch() {

		CameraDevice.Instance.SetFlashTorchMode(lamp);
		lamp = !lamp;
	}
}
