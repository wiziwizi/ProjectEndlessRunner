using UnityEngine;
using System.Collections;

public class PlayerSpriteFlip : MonoBehaviour {

	/*This Class is responsible for the Flipping the Sprite needed for the PlayerMovement (Vertical)*/

	private bool lookRight = true;
	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		if(InputController.PlayerMove > 0 && !lookRight){
//			FlipSprite ();
//		} else if(InputController.PlayerMove < 0 && lookRight){
//			FlipSprite ();
//		}
	}

	void FlipSprite(){
		lookRight = !lookRight;
		Vector3 spriteScale = transform.localScale;
		spriteScale.x *= -1;
		transform.localScale = spriteScale;
	}
}
