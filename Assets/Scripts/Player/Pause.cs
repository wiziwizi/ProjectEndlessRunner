using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	[SerializeField] private MenuManagement canvasHolder;
	[SerializeField] private GameObject canvasID;

	void Start()
	{
		canvasHolder = canvasHolder.GetComponent<MenuManagement> ();
	}

	public void OnPause()
	{
		print ("Start Pause");
		if(Time.timeScale == 0) {
			Time.timeScale = 1;
			canvasHolder.SetCanvasFalse ();
		}
		else if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			canvasHolder.OnButtonPress(canvasID);
		}
	}
}
