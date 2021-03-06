﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Menu management.
/// is responisible for activating and deactivating canvases.
/// </summary>

public class MenuManagement : MonoBehaviour {

	[SerializeField]
	private GameObject[] canvas; // canvas 0 is Main Canvas = is active;

	// Use this for initialization
	void Start ()
	{
		SetCanvasFalse ();
		canvas [0].SetActive (true); //sets all Canvas of disabled exept the first.
	}

	public void OnButtonPress (GameObject canvasID)
	{
		SetCanvasFalse ();
		for(int i = 0; i < canvas.Length; i++)
		{
			if (canvas[i].name == canvasID.name) // sets only the given canvas active.
			{
				canvas [i].SetActive (true);
			}
		}
	}

	public void SetCanvasFalse()
	{
		for(int i = 0; i < canvas.Length; i++)
		{
			canvas [i].SetActive (false); // sets every canvas off.
		}
	}
}
