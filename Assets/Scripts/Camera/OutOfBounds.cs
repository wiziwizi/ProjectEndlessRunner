using UnityEngine;
using System.Collections;

/// <summary>
/// Out of bounds.
/// this class is resposible for killing the player when out of bounds
/// </summary>

public class OutOfBounds : MonoBehaviour {

	[SerializeField] private string tagOfObject; // the tag of object you want to check if it is out of bouds.

	private Health lifeScript;	//make a reference to the players health

	void Update()
	{
		//holds the boundery always at the left side of the camera, no matter what aspact you look at it.
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/2, Camera.main.nearClipPlane));

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagOfObject)) //if one of the players collides with the "Out of bounds"
		{
			lifeScript = other.GetComponent<Health>();	//get this players life script
			lifeScript.LoseLife (1); // removes a life from the player that hit the boundery.
		}
	}
}
