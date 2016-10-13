using UnityEngine;
using System.Collections;

public class ChunkLoader : MonoBehaviour {

	[SerializeField]
	private GameObject[] levelChunks;
	private Vector3 backGroundSize = new Vector3(75,0,0);
	private int randomNumber;
	private int oldRandomNumber;

	void Start()
	{
		
		randomNumber = Random.Range (0, 2);
		print (randomNumber);
		levelChunks[randomNumber].SetActive (true);
		oldRandomNumber = randomNumber;
	}

	void OnBecameInvisible()
	{
		levelChunks[oldRandomNumber].SetActive (false);
		randomNumber = Random.Range (0, 2);
		print (randomNumber);
		transform.position += backGroundSize;
		levelChunks[randomNumber].SetActive (true);
		oldRandomNumber = randomNumber;
	}
}
