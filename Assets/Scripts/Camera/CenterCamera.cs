using UnityEngine;
using System.Collections;

public class CenterCamera : MonoBehaviour {

	[SerializeField]
	private Transform[] points;

	[SerializeField]
	private bool canNotMoveLeft;

	private Vector3 center;
	private Vector3 newPosition;
	private Vector3 oldPosition;

	void Update ()
	{
		newPosition = transform.position;

			if(points.Length < 2)
			{
				transform.position = new Vector3 (points [0].transform.position.x, points [0].transform.position.y, -10);
			}
			else
			{
				center = ((points [0].position - points [1].position) / 2.0f) + points [1].position;

				if (canNotMoveLeft)
				{
					if (center.x < transform.position.x)
					{
						center.x = transform.position.x;
					}
				}

				transform.position = new Vector3 (center.x, center.y, -10);
			}
			
		oldPosition = newPosition;
	}
}