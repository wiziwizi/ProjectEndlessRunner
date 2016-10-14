using UnityEngine;
using System.Collections;

/// <summary>
/// This script is responisible for Pause.
/// </summary>

public class Pause : MonoBehaviour {

	[SerializeField] private MenuManagement canvasHolder; // for the call of the pause canvas.
	[SerializeField] private GameObject canvasID;

	void Start()
	{
		canvasHolder = canvasHolder.GetComponent<MenuManagement> ();
	}

	public void OnPause()
	{
//		print ("Start Pause");
		if(Time.timeScale == 0) { // removes the game from pause.
			Time.timeScale = 1;
			canvasHolder.SetCanvasFalse (); // disabbles the canvas.
		}
		else if(Time.timeScale == 1) // sets the game on pause.
		{
			Time.timeScale = 0;
			canvasHolder.OnButtonPress(canvasID); // enables the given canvas.
		}
	}
}
