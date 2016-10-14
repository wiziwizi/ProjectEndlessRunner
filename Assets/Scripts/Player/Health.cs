using UnityEngine;
using System.Collections;

/// <summary>
/// Health.
/// This Class is resposible for all the Health of the Player
/// </summary>

public class Health : MonoBehaviour {
	
	[SerializeField] private int health;	//Total amount of health
	[SerializeField] private int playerID;	//The ID of the player (int)
	private bool isDead = false;	//Set the player as dead or not

	[SerializeField] private string otherPlayerName;	//The name of the Other Player
	private Vector3 otherPlayerPosition;	//The Position of the Other Player

	[SerializeField] private GameObject sceneLoaderObject;	//Reference to the Sceneloader Object
	private SceneLoader sceneLoader;	//Reference to the Sceneloader
	private Animator anim;	//Reference to the animator component
	private PlayerController playerController;	//Reference to the PlayerController

	void Awake()
	{
		playerController = GetComponent<PlayerController> ();	//Get the reference to PlayerController
		anim = GetComponent<Animator> ();	//Get the reference to Animator
		sceneLoader = sceneLoaderObject.GetComponent<SceneLoader>();	//Get reference to SceneLoader
		playerController.enabled = true;	//Make sure PlayerController is Enabled
		isDead = false;	//Set the player to is NOT dead
	}

	public void LoseLife(int retract)
	{
		otherPlayerPosition = GameObject.Find(otherPlayerName).transform.position;	//Find the other players position
		health -= retract;	//Retract the X number from the players health
		transform.position = new Vector3 (otherPlayerPosition.x, 10, otherPlayerPosition.z);	//Transform the player to the location of the otherplayer

		if (health <= 0)	//If the player is dead
		{
			PlayerPrefs.SetInt ("playerID", playerID);	//Set the players ID to its correct ID
			StartCoroutine (End());	//Start the End-Game Coroutine
			//Dead animation
			playerController.enabled = false;	//Disable the PlayerController (so he cant move)
			isDead = true;	//The player is dead
			anim.SetBool ("Dead", isDead);	//Set the animator to Death animate
			transform.position = new Vector3 (otherPlayerPosition.x, otherPlayerPosition.y, otherPlayerPosition.z);	//Set the player to the location of the other
		}
	}

	IEnumerator End()
	{
		yield return new WaitForSeconds (3f);	//Wait for 3seconds
		if(sceneLoader != null)	//Check if there is a sceneloader
		{
			sceneLoader.LoadScene (2);	//Reload this scene
		}
	}
}