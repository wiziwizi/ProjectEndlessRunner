using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public void LoadScene (int levelNumber)
	{
		Time.timeScale = 1;
		SceneManager.LoadScene (levelNumber);// Loads the scene with the given number.
	}
}
