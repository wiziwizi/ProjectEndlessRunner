using UnityEngine;
using System.Collections;

public class PickUpRemover : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){ // if the player hits the pickup.
			this.gameObject.SetActive (false); // sets the object false.
		}
	}

}
