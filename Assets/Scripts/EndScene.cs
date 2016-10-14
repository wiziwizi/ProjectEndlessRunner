using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// End scene.
/// This Class is responsible for displaying the Game-Over winning player
/// </summary>

public class EndScene : MonoBehaviour {

	private int playerID;
	[SerializeField] private GameObject[] Player;
	[SerializeField] private Text text;

	// Use this for initialization
	void Start ()
	{
		playerID = PlayerPrefs.GetInt ("playerID"); // gets the player id who won.

		if(playerID == 1)
		{
			Player [1].SetActive (true); // displays player 2 on the screen.
			text.text = "2";
		}
		else
		{
			Player [0].SetActive (true); // displays player 1 on the screen.
		}
	}
}
