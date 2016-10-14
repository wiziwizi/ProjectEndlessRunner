using UnityEngine;
using System.Collections;

/// <summary>
/// Center camera.
/// This Class is resposible for the movement of the Camera
/// </summary>

public class CenterCamera : MonoBehaviour {

	[SerializeField] private Transform[] points;	//The positions of the players
	[SerializeField] private bool canNotMoveLeft;	//The camera cannot move left

	private Vector3 center;		//the center between the points
	private Vector3 newPosition;	//the new position of the camera
	private Vector3 oldPosition;	//the old position of the camera

	void Update ()
	{
		newPosition = transform.position;	//set the new position to the current position

			if(points.Length < 2)	//when there are less than 2 players
			{
				transform.position = new Vector3 (points [0].transform.position.x, points [0].transform.position.y, -10);	//set the camera po player 1
			}
			else
			{
				center = ((points [0].position - points [1].position) / 2.0f) + points [1].position;	//otherwise set the center between the 2players positions

				if (canNotMoveLeft)	//if the camera cannot move left
				{
					if (center.x < transform.position.x) //if the center x position smaller than the current x position
					{
						center.x = transform.position.x; //the center x is the current position
					}
				}

				transform.position = new Vector3 (center.x, center.y + 3f, -10);	//set the camera's position to the center with a slight offset
			}
			
		oldPosition = newPosition;	//set the last position as the old position
	}
}