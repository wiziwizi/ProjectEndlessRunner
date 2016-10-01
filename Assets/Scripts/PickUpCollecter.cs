using UnityEngine;
using System.Collections;

public class PickUpCollecter : MonoBehaviour {

	[SerializeField] private GameObject[] allPickUps;
	private int allPickUpsCount;

	// Use this for initialization
	void Start () {
		foreach(GameObject pickUp in allPickUps){
			allPickUpsCount++;
			//print (allPickUpsCount);
		}
		allPickUps = new GameObject[allPickUpsCount];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
