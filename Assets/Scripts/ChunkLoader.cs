using UnityEngine;
using System.Collections;

/// <summary>
/// Chunk loader.
/// This class is responsible for all the LevelChunks positions and placement.
/// </summary>

public class ChunkLoader : MonoBehaviour {

	[SerializeField]
	private GameObject[] levelChunks;	//All the prefab LevelChunks
	private Vector3 backGroundSize = new Vector3(75,0,0);	//Totalsize of the Background (of the chunk)
	private int randomNumber;	//Needed to place a random LevelChunk
	private int oldRandomNumber;	//Needed to remove the random levelChunk

	void Start()
	{
		randomNumber = Random.Range (0, 2);	//Generate random float
//		print (randomNumber);
		levelChunks[randomNumber].SetActive (true);	//Get a random levelchunk and activate
		oldRandomNumber = randomNumber;	//Set the old to this number
	}

	void OnBecameInvisible()
	{
		levelChunks[oldRandomNumber].SetActive (false);	//take the oldChunk and de-activate
		randomNumber = Random.Range (0, 2);	//Generate a new random float
//		print (randomNumber);
		transform.position += backGroundSize;	//Position the new chunk passed the prev BG
		levelChunks[randomNumber].SetActive (true);	//Get a new Random Chunk and activate
		oldRandomNumber = randomNumber;	//set the old to this new number
	}
}
