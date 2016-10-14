using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public void OnPause()
	{
		print ("Start Pause");
		if(Time.timeScale == 0) {
			Time.timeScale = 1;
			print ("End Pause");
		}
		else if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			print ("Enable Pause");
		}
	}
}
