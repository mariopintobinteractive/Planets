/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Qualcomm Connected Experiences, Inc.
==============================================================================*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

/// <summary>
/// This behaviour associates a Virtual Button with a game object. Use the
/// functionality in ImageTargetBehaviour to create and destroy Virtual Buttons
/// at run-time.
/// </summary>
public class VirtualButtonBehaviour : VirtualButtonAbstractBehaviour
{
	public void OnButtonPressed(VirtualButtonBehaviour vb){
		Debug.Log ("Pressed");
	}
	
	public void OnButtonReleased(VirtualButtonBehaviour vb){
		Debug.Log("Released");
	}
}
