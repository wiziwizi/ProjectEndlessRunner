using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {

	/*This Class is responsible for all the Animations for the PlayerCharacter*/
	private Animator p_anim;

	// Use this for initialization
	void Start () {
		p_anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
