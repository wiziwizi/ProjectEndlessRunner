using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

	[SerializeField] private Health[] players;
	[SerializeField] private GameObject[] lifes;

	private int player1;
	private int player2;

	private int oldHealth1;
	private int oldHealth2;

	private int counter1;
	private int counter2 = 3;

	void Update ()
	{
		player1 = players [0].GetComponent<Health>().GetHealth;
		player2 = players [1].GetComponent<Health>().GetHealth;

		if(player1 < oldHealth1)
		{
			lifes [counter1].SetActive (false);
			counter1++;
		}

		if(player2 < oldHealth2)
		{
			lifes [counter2].SetActive (false);
			counter2++;
		}

		oldHealth1 = player1;
		oldHealth2 = player2;
	}
}
