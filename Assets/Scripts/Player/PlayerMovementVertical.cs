using UnityEngine;
using System.Collections;

public class PlayerMovementVertical : MonoBehaviour {

	/*This Class is responsible for all the Vertical Movement for the PlayerCharacter*/

	private float moveForce = 300f;
	private float maxSpeed = 5f;
	private Rigidbody2D rgdbody;

	// Use this for initialization
	void Start () {
		rgdbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		if(InputController.PlayerMove * rgdbody.velocity.x < maxSpeed){
//			rgdbody.AddForce (Vector2.right * InputController.PlayerMove * moveForce);
//		}

//		if(Mathf.Abs(rgdbody.velocity.x) > maxSpeed){
//			rgdbody.velocity = new Vector2 (Mathf.Sign(rgdbody.velocity.x) * maxSpeed, rgdbody.velocity.y);
//		}
	}

	public void MovePlayer(){
		
	}
}
