﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScene : MonoBehaviour {

	private int playerID;
	[SerializeField] private GameObject[] Player;
	[SerializeField] private Text text;

	// Use this for initialization
	void Start ()
	{
		playerID = PlayerPrefs.GetInt ("playerID");

		Debug.Log (playerID);

		if(playerID == 1)
		{
			Player [1].SetActive (true);
			text.text = "2";
		}
		else
		{
			Player [0].SetActive (true);
		}
	}
}