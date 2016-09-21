using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Array : MonoBehaviour {

	List<GameObject> list = new List<GameObject>();

	void Start ()
	{
		for (int i = 0; i<4; i++)
		{
			list.Add (new GameObject (i.ToString ()));
			Debug.Log (list.Count);
			Debug.Log (list [i].name);
		}
	}
}
