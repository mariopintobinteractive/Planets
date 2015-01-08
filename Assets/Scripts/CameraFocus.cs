﻿using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		bool focusModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		
		if (!focusModeSet) {
			Debug.Log("Failed to set focus mode (unsupported mode).");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
