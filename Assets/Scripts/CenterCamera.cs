using UnityEngine;
using System.Collections;

public class CenterCamera : MonoBehaviour {

	[SerializeField]
	private Transform[] points;
	private Vector3 center;

	private CameraLock cameraLock;

	void Awake ()
	{
		cameraLock = GetComponent<CameraLock>();
	}

	void Update ()
	{
		//Vector3 currentCameraPosition = cameraLock.getVector ();

		//Debug.Log (currentCameraPosition);

		if(points.Length < 2)
		{
			transform.position = new Vector3 (points [0].transform.position.x, points [0].transform.position.y, -10);
		}
		else
		{
			center = ((points [0].position - points [1].position) / 2.0f) + points [1].position;
			transform.position = new Vector3 (center.x, center.y, -10);
		}
	}
}