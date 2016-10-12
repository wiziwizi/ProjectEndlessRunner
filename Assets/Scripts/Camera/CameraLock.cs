using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {
	private Vector3 oldPosition;
	private Vector3 newPosition;
	private Vector3 currentPosition;

	void Update()
	{
		newPosition = transform.position;

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, oldPosition.x, transform.position.x + 10),transform.position.y,transform.position.z);
		//Debug.Log ("current: " + transform.position.x);
		//Debug.Log ("old: " + oldPosition.x);

		oldPosition = newPosition;
	}

	public Vector3 getVector()
	{
		return currentPosition;
	}
}
