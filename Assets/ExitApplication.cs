using UnityEngine;
using System.Collections;

public class ExitApplication : MonoBehaviour {

	public void OnButtonPress(){
		Screen.fullScreen = false;
		Application.Quit ();
	}
}
