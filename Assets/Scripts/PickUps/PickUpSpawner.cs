using UnityEngine;
using System.Collections;

public class PickUpSpawner : MonoBehaviour {

	[SerializeField] private GameObject[] allPickUps;
	[SerializeField] private Vector2 spawnPosition;	//X= Minimum, Y= Maximum
	[SerializeField] private Vector2 spawnWaitTime;	//X= Minimum, Y= Maximum


	// Use this for initialization
	void Start () {
		SpawnPickUps ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnPickUps (){
//		Instantiate (allPickUps[Random.Range(0, allPickUps.GetLength(0))], new Vector3(Random.Range(spawnPosition.x, spawnPosition.y),Random.Range(spawnPosition.x, spawnPosition.y),0f), Quaternion.identity);
		Invoke ("SpawnPickUps", Random.Range(spawnWaitTime.x, spawnWaitTime.y));
	}
}
