using UnityEngine;
using System.Collections;

/// <summary>
/// Paralax back ground.
/// This Script is Resposible for the Paralax Scrolling of the Backgrounds
/// </summary>

public class ParalaxBackGround : MonoBehaviour {

	private Vector2 currentCameraPosition;	//Position of the Camera
	private Vector2 previousCamPos;			//Last Position of the Camera
	[SerializeField] private float speed;	//Speed for the Offset change

	private Renderer renderer;	//The renderer of the Background

	void Awake()
	{
		renderer = GetComponent<Renderer> ();	//Fetch the reference to the Renderer
	}
	void Update ()
	{
		currentCameraPosition = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);	//Get the Current Position of the camera

		if (currentCameraPosition.x > previousCamPos.x)	//Whenever the X position of the camera is smaller than the previous position
		{
			Vector2 offset = new Vector2 (Time.deltaTime * speed, 0);	//set the ofset of the Background
			renderer.material.mainTextureOffset += offset;	//scroll the material on the renderer
		}
		previousCamPos = currentCameraPosition;	//set this last position to the Previous position
	}
}