using UnityEngine;
using System.Collections;

public class OuOfBounds : MonoBehaviour {

	[SerializeField] private string tagOfObject;
	private Health lifeScript;


	void Awake()
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagOfObject))
		{
			Debug.Log ("y");
			lifeScript = other.GetComponent<Health>();
			lifeScript.LoseLife (1);
		}
	}
}
