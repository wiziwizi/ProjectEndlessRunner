using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private bool p_lookR = true;
	private bool p_jump = false;

	private float p_moveForce = 300f;
	private float p_maxSpeed = 5f;
	private float p_jumpForce = 500f;
	[SerializeField] private Transform p_groundCheck;

	private bool p_onGround = false;
	private Animator p_anim;
	private Rigidbody2D p_rb;

	[SerializeField] private string jumpButton = "Jump_P1";
	[SerializeField] private string horizontalAxis = "Horizontal_P1";

	// Use this for initialization
	void Awake () {
		p_anim = GetComponent<Animator> ();
		p_rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	//	p_onGround = Physics2D.Raycast (transform.position, p_groundCheck.position, 2, 1 << LayerMask.NameToLayer("Ground") );
		p_onGround = Physics2D.Linecast(transform.position, p_groundCheck.position, 1<<LayerMask.NameToLayer("Ground"));

		if(Input.GetButtonDown(jumpButton) && p_onGround){
			p_jump = true;
		}
	}

	void FixedUpdate(){
		float p_hori = Input.GetAxis (horizontalAxis);

		p_anim.SetFloat ("Speed", Mathf.Abs(p_hori));
		//Check under speed limit;
		if(p_hori * p_rb.velocity.x < p_maxSpeed){
			p_rb.AddForce (Vector2.right * p_hori * p_moveForce);
		}
		//Too fast;
		if(Mathf.Abs(p_rb.velocity.x) > p_maxSpeed){
			p_rb.velocity = new Vector2 (Mathf.Sign(p_rb.velocity.x) * p_maxSpeed, p_rb.velocity.y);
		}

		if(p_hori > 0 && !p_lookR){
			Flip ();
		} else if(p_hori < 0 && p_lookR){
			Flip ();
		}

		if(p_jump){
			p_anim.SetTrigger ("Jump");
			p_rb.AddForce (new Vector2(0f, p_jumpForce));
			p_jump = false;
		}
		p_anim.SetBool ("OnGround", p_onGround);
	}

	void Flip (){
		p_lookR = !p_lookR;
		Vector3 p_Scale = transform.localScale;
		p_Scale.x *= -1;
		transform.localScale = p_Scale;
	}

	public void SetMaxSpeed (float newMaxSpeed){
		p_maxSpeed = newMaxSpeed;
	}
}