using UnityEngine;
using System.Collections;

public class ParalaxBackGround : MonoBehaviour {

	private Vector2 currentCameraPosition;
	private Vector2 previousCamPos;
	[SerializeField]
	private float speed;

	private Renderer renderer;

	void Awake()
	{
		renderer = GetComponent<Renderer> ();
	}
	void Update ()
	{
		currentCameraPosition = new Vector2(Camera.main.transform.position.x, Camera.main.transform.position.y);

		if (currentCameraPosition.x > previousCamPos.x)
		{
			Vector2 offset = new Vector2 (Time.deltaTime * speed, 0);
			renderer.material.mainTextureOffset += offset;
		}
		previousCamPos = currentCameraPosition;
	}
}