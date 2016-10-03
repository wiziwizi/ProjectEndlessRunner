using UnityEngine;
using System.Collections;

public class MenuManagement : MonoBehaviour {

	[SerializeField]
	private GameObject[] canvas; // canvas 0 is Main Canvas = is active;

	// Use this for initialization
	void Start ()
	{
		SetCanvasFalse ();
		canvas [0].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPress (GameObject canvasID)
	{
		SetCanvasFalse ();
		for(int i = 0; i < canvas.Length; i++)
		{
			if (canvas[i].name == canvasID.name)
			{
				canvas [i].SetActive (true);
			}
		}
	}

	void SetCanvasFalse()
	{
		for(int i = 0; i < canvas.Length; i++)
		{
			canvas [i].SetActive (false);
		}
	}
}
