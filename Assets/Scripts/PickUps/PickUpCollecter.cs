using UnityEngine;
using System.Collections;

/// <summary>
/// activates the Pickup.
/// </summary>

public class PickUpCollecter : MonoBehaviour {

	private Vector2 timer; // duration of the power up. x = current time, y = max time.
	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<PlayerController> (); 
		timer.y = 10f; // sets the max time at 10.
	}

	void OnTriggerEnter2D(Collider2D pickUp){
		if(pickUp.CompareTag("SpeedUp")){ // if the pickup Speed up is collected,
			StartCoroutine("SpeedUp");// start corotine Seed up.
		} else if(pickUp.CompareTag("SpeedDown")){ // if the pickup Speed down is collected,
			StartCoroutine ("SpeedDown"); // start corotine Seed down.
		}
	}

	private IEnumerator SpeedUp(){
		playerController.SetMaxSpeed(7f); // boosts the speed to 7. 
		while (timer.x < timer.y) { // if the curent timer = under the max timer.
			timer.x++;
			yield return new WaitForSeconds (1f);
		}
		timer.x = 0f; // reset timer.
		playerController.SetMaxSpeed(5f); // reset speed.
		yield return null;
	}

	private IEnumerator SpeedDown(){
		playerController.SetMaxSpeed(3f);
		while(timer.x < timer.y){ // if the curent timer = under the max timer.
			timer.x++;
			yield return new WaitForSeconds (1f);
		}
		timer.x = 0f; // reset timer.
		playerController.SetMaxSpeed(5f); // reset speed.
		yield return null;
	}
}
