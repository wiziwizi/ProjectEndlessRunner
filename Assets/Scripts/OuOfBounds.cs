using UnityEngine;
using System.Collections;

public class OuOfBounds : MonoBehaviour {

	[SerializeField]
	private string tagOfObject;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagOfObject))
		{
			Debug.Log ("trigger");
		}
	}
}
