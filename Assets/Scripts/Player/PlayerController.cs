using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool player_flip = true;
	private bool player_jump = false;

	private float player_moveForce = 300f;
	private float player_maxSpeed = 5f;
	private float player_jumpForce = 500f;
	[SerializeField] private Transform player_groundCheck;

	private bool player_onGround = false;
	private Animator player_anim;
	private Rigidbody2D player_rb;

	[SerializeField] private string jumpButton = "Jump_P1";
	[SerializeField] private string horizontalAxis = "Horizontal_P1";

	// Use this for initialization
	void Awake () {
		player_anim = GetComponent<Animator> ();
		player_rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	//	p_onGround = Physics2D.Raycast (transform.position, p_groundCheck.position, 2, 1 << LayerMask.NameToLayer("Ground") );
		player_onGround = Physics2D.Linecast(transform.position, player_groundCheck.position, 1<<LayerMask.NameToLayer("Ground")); // checks if the ground is close enough to jump.

		if(Input.GetButtonDown(jumpButton) && player_onGround){ // if the player trys to jump and onground = true.
			player_jump = true;
		}
	//}

	//void FixedUpdate(){
		float player_hori = Input.GetAxis (horizontalAxis);

		player_anim.SetFloat ("Speed", Mathf.Abs(player_hori));
		//Check under speed limit;
		if(player_hori * player_rb.velocity.x < player_maxSpeed){
			player_rb.AddForce (Vector2.right * player_hori * player_moveForce);
		}
		//Too fast;
		if(Mathf.Abs(player_rb.velocity.x) > player_maxSpeed){
			player_rb.velocity = new Vector2 (Mathf.Sign(player_rb.velocity.x) * player_maxSpeed, player_rb.velocity.y);
		}

		if(player_hori > 0 && !player_flip){
			Flip ();
		} else if(player_hori < 0 && player_flip){
			Flip ();
		}

		if(player_jump){
			player_anim.SetTrigger ("Jump");
			player_rb.AddForce (new Vector2(0f, player_jumpForce));
			player_jump = false;
		}
		player_anim.SetBool ("OnGround", player_onGround);
	}

	void Flip (){
		player_flip = !player_flip;
		Vector3 p_Scale = transform.localScale;
		p_Scale.x *= -1;
		transform.localScale = p_Scale;
	}

	public void SetMaxSpeed (float newMaxSpeed){
		player_maxSpeed = newMaxSpeed;
	}
}