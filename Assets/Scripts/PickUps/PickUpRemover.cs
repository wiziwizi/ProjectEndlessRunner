using UnityEngine;
using System.Collections;

public class PickUpRemover : MonoBehaviour {

	GameObject OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			GetPickUp ();
			this.gameObject.SetActive (false);
		}
		return null;
	}

	public GameObject GetPickUp(){
		return this.gameObject;
	}
}
