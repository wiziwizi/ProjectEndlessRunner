using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {
	private Vector3 oldPosition;
	private Vector3 newPosition;

	void Update()
	{
		newPosition = transform.position;

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, oldPosition.x, transform.position.x + 10),transform.position.y,transform.position.z);

		oldPosition = newPosition;
	}

}
