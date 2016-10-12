using UnityEngine;
using System.Collections;

public class PickUpCollecter : MonoBehaviour {

	private GameObject collectedPickUp;
	private Rigidbody2D rgdbody;
	private Vector2 timer;

	// Use this for initialization
	void Start () {
		rgdbody = GetComponent<Rigidbody2D> ();
		timer.y = 5f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D pickUp){
		if(pickUp.CompareTag("SpeedUp")){
			print ("Le Speed UP");
			StartCoroutine("SpeedUp");
		} else if(pickUp.CompareTag("SpeedDown")){
			print ("Le Speed Down");
		}
	}

	private IEnumerator SpeedUp(){
		print ("Start SpeedUp");
		while (timer.x < timer.y) {
			print ("SpeedUP time: "+timer.x);
			timer.x++;
			rgdbody.drag = -10f;
		}
		print ("SpeedUp done");
		timer.x = 0f;
		rgdbody.drag = 0;
		yield return null;
	}

	private IEnumerator SpeedDown(){
		print ("Start SpeedDown");
		while(timer.x < timer.y){
			print ("SpeedDown Time:"+timer.x);
			timer.x++;
			rgdbody.drag = 10f;
		}
		print ("SpeedDown done");
		timer.x = 0f;
		rgdbody.drag = 0;
		yield return null;
	}
}
