using UnityEngine;
using System.Collections;

public class PickUpCollecter : MonoBehaviour {

	private GameObject collectedPickUp;
	private Rigidbody2D rgdbody;
	private Vector2 timer;

	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		rgdbody = GetComponent<Rigidbody2D> ();
		playerController = GetComponent<PlayerController> ();
		timer.y = 10f;
	}

	void OnTriggerEnter2D(Collider2D pickUp){
		if(pickUp.CompareTag("SpeedUp")){
//			print ("Le Speed UP");
			StartCoroutine("SpeedUp");
		} else if(pickUp.CompareTag("SpeedDown")){
//			print ("Le Speed Down");
			StartCoroutine ("SpeedDown");
		}
	}

	private IEnumerator SpeedUp(){
		print ("Start SpeedUp");
		while (timer.x < timer.y) {
//			print ("SpeedUP time: "+timer.x);
			timer.x++;
			playerController.SetMaxSpeed(7f);
			yield return new WaitForSeconds (1f);
		}
		print ("SpeedUp done");
		timer.x = 0f;
		playerController.SetMaxSpeed(5f);
		yield return null;
	}

	private IEnumerator SpeedDown(){
		print ("Start SpeedDown");
		playerController.SetMaxSpeed(3f);
		while(timer.x < timer.y){
//			print ("SpeedDown Time:"+timer.x);
			timer.x++;
			yield return new WaitForSeconds (1f);
		}
		print ("SpeedDown done");
		timer.x = 0f;
		playerController.SetMaxSpeed(5f);
		yield return null;
	}
}
