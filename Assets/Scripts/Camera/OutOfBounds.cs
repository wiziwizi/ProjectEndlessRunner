﻿using UnityEngine;
using System.Collections;

public class OutOfBounds : MonoBehaviour {

	[SerializeField] private string tagOfObject; // the tag of object you want to check if it is out of bouds.

	private Health lifeScript;

	void Update()
	{
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/2, Camera.main.nearClipPlane));
		//holds the boundery always at the left side of the camera, no matter what aspact you look at it.
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagOfObject))
		{
			lifeScript = other.GetComponent<Health>();
			lifeScript.LoseLife (1); // removes a life from the player that hit the boundery.
		}
	}
}
