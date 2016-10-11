using UnityEngine;
using System.Collections;

public class OuOfBounds : MonoBehaviour {

	[SerializeField] private string tagOfObject;
	private Health lifeScript;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagOfObject))
		{
			lifeScript = other.GetComponent<Health>();
			lifeScript.LoseLife (1);
		}
	}
}
