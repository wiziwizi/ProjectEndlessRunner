using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour {

	[SerializeField]
	private GameObject[] canvas;

	// Use this for initialization
	void Start ()
	{
		for(int i = 0; i < canvas.Length; i++)
		{
			canvas [i].SetActive (false);
		}
		canvas [0].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPress (GameObject canvasID)
	{
		Debug.Log ("Hallo");
	}
	public void LoadScene (int levelNumber)
	{
		SceneManager.LoadScene (levelNumber);
	}
}
