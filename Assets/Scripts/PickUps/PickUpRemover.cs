using UnityEngine;
using System.Collections;

public class PickUpRemover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	GameObject OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			GetPickUp ();
			this.gameObject.SetActive (false);
		}
		return null;
	}

	public GameObject GetPickUp(){
		print (this.gameObject);
		return this.gameObject;
	}
}
