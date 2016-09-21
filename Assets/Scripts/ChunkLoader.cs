using UnityEngine;
using System.Collections;

public class ChunkLoader : MonoBehaviour {

	[SerializeField]
	private GameObject[] LevelChunks;
	private Vector3 BGSize = new Vector3(50,0,0);
	private int RandomNumber;
	private int OldRandomNumber;

	void Start()
	{
		RandomNumber = Random.Range (0, 2);
		LevelChunks[RandomNumber].SetActive (true);
		OldRandomNumber = RandomNumber;
	}

	void OnBecameInvisible()
	{
		LevelChunks[OldRandomNumber].SetActive (false);
		RandomNumber = Random.Range (0, 2);
		Debug.Log (RandomNumber);
		transform.position += BGSize;
		LevelChunks[RandomNumber].SetActive (true);
		OldRandomNumber = RandomNumber;
	}
}
