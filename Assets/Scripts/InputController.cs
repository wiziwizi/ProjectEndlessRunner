using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	/*This Class is responsible for all the UserInput needed for the Game*/
	public delegate void JumpInput (bool inputJump);
	public static JumpInput PlayerJump;

	public delegate void HorizontalInput(float inputHorizontal);
	public static HorizontalInput PlayerMove;

	[SerializeField] private string jumpButton = "Jump_P1";
	[SerializeField] private string horizontalAxis = "Horizontal_P1";

	//private bool inputJump;
	//private float inputHorizontal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bool inputJump = Input.GetButtonDown (jumpButton);
		float inputHorizontal = Input.GetAxis (horizontalAxis);

		PlayerJump (inputJump);
		PlayerMove (inputHorizontal);


		if(inputJump){
//			PlayerMovementJump.Jump ();
		}
		if(inputHorizontal != 0){
//			PlayerMovementVertical.MovePlayer ();
		}
	}
}

// Send the input to the scripts