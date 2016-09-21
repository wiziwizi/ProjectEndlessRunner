using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] private int m_maxSpeed;
	private Rigidbody2D rigid;
	private float moveX = 0f;
	private float moveY = 0f;
	private bool onGround = true;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		moveX = Input.GetAxis ("Horizontal");
//		moveY = Input.GetButton ("Fire0");
		rigid.velocity = new Vector2 (moveX*m_maxSpeed, 0f);
	}
}
