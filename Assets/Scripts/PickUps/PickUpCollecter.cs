using UnityEngine;
using System.Collections;

public class PickUpCollecter : MonoBehaviour {

	private GameObject collectedPickUp;
	private Vector2 timer;
	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<PlayerController> ();
		timer.y = 10f;
	}

	void OnTriggerEnter2D(Collider2D pickUp){
		if(pickUp.CompareTag("SpeedUp")){
			StartCoroutine("SpeedUp");
		} else if(pickUp.CompareTag("SpeedDown")){
			StartCoroutine ("SpeedDown");
		}
	}

	private IEnumerator SpeedUp(){
		while (timer.x < timer.y) {
			timer.x++;
			playerController.SetMaxSpeed(7f);
			yield return new WaitForSeconds (1f);
		}
		timer.x = 0f;
		playerController.SetMaxSpeed(5f);
		yield return null;
	}

	private IEnumerator SpeedDown(){
		playerController.SetMaxSpeed(3f);
		while(timer.x < timer.y){
			timer.x++;
			yield return new WaitForSeconds (1f);
		}
		timer.x = 0f;
		playerController.SetMaxSpeed(5f);
		yield return null;
	}
}
