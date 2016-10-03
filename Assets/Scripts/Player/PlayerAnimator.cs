using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {

	/*This Class is responsible for all the Animations for the PlayerCharacter*/
	private Animator animate;

	// Use this for initialization
	void Start () {
		animate = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
//		animate.SetFloat ("Speed", Mathf.Abs(InputController.PlayerMove));

//		if(PlayerMovementJump.CanJump && InputController.JumpInput){
//			animate.SetTrigger ("Jump");
//		}
//		animate.SetBool ("OnGround", PlayerMovementJump.OnGround);
	}
}
