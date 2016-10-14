using UnityEngine;
using System.Collections;

/// <summary>
/// Input controller.
/// This Class is responsible for all the UserInput needed for the Game
/// </summary>

public class InputController : MonoBehaviour {

	[SerializeField] private string jumpButton = "Jump_P1";	//The input-string in inputSystem for Jumping
	[SerializeField] private string horizontalAxis = "Horizontal_P1";	//The input-string in inputSystem for Moving
	[SerializeField] private string pauseButton = "Pause_P1"; 	//The input-string in inputSystem for Pause
	private bool inputJump;	//The fetched Input for Jump
	private float inputHorizontal;	//The fetched Input for Moving
	private bool inputPause;	//The fetched Input for Pause
	[SerializeField] private Pause pauseRef;	//The Reference for Pause

	// Use this for initialization
	void Start () {
		//if(GetComponent<Pause> () != null){	//check if there is a pauseScript
			pauseRef = pauseRef.GetComponent<Pause> ();	//Link the pause to reference
	//	}
	}
	
	// Update is called once per frame
	void Update () {
		bool inputJump = Input.GetButtonDown (jumpButton);	//Check for Jump Input
		float inputHorizontal = Input.GetAxis (horizontalAxis);	//Check for Move Input
		bool inputPause = Input.GetButtonDown (pauseButton);	//Check for Pause Input

		if(inputJump){	//If there was Jump Input
			JumpInput ();	//Activate Jump
		}
		if(inputHorizontal != 0){	//If the was Move Input
			MoveInput ();	//Activate Move
		}
		if(inputPause){	//If there was Pause Input
			PauseInput ();	//Activate Pause
		}
	}

	public void JumpInput (){
//		return inputPause;
	}

	public void MoveInput(){
	//	return horizontalAxis;
	}

	public void PauseInput(){
		//return inputPause;
		pauseRef.OnPause();	//Set the game on Pause

	}
}