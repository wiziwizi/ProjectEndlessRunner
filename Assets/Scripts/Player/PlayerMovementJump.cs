using UnityEngine;
using System.Collections;

public class PlayerMovementJump : MonoBehaviour {

	/*This Class is responsible for all the Jump-ability for the PlayerCharacter*/
	private bool canJump = true;
	private bool onGround = false;
	private bool doesJump;
	private float jumpForce = 500f;
	private Rigidbody2D rgdbody;
	[SerializeField] private Transform groundCheck;

	// Use this for initialization
	void Start () {
		rgdbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		onGround = Physics2D.Raycast (transform.position, groundCheck.position, 1, 1<<LayerMask.NameToLayer("Ground"));
		}

	void FixedUpdate (){
		if(canJump){
			rgdbody.AddForce (new Vector2(0f, jumpForce));
			canJump = false;
		}
	}

	public void Jump(){
		if(onGround){
			canJump = true;
		}
	}
}
