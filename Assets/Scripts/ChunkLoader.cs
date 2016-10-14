using UnityEngine;
using System.Collections;

/// <summary>
///  This script is responisible for Chunk loader.
/// </summary>

public class ChunkLoader : MonoBehaviour {

	[SerializeField]
	private GameObject[] levelChunks;
	private Vector3 backGroundSize = new Vector3(75,0,0); // the length of 1 background * the amount of chunks (3).
	private int randomNumber;
	private int oldRandomNumber;

	void Start()
	{
		
		randomNumber = Random.Range (0, 3); // Gets a number from 0 to 2.
		levelChunks[randomNumber].SetActive (true);// 1 of the 3 chunks get activated
		oldRandomNumber = randomNumber;// the random number is stored.
	}

	void OnBecameInvisible()
	{
		levelChunks[oldRandomNumber].SetActive (false);// Disables the old Chunk when it is out of sight.
		randomNumber = Random.Range (0, 3);
		transform.position += backGroundSize;// Sets the position on the end of the level to load a new chunk.
		levelChunks[randomNumber].SetActive (true);
		oldRandomNumber = randomNumber;
	}
}
