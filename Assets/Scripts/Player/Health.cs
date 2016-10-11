using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[SerializeField] private int health;
	[SerializeField] private string otherPlayerName;

	private SceneLoader sceneLoader;
	[SerializeField] private GameObject sceneLoaderObject;

	private Vector3 otherPlayerPosition;

	[SerializeField] private int playerID;

	void Awake()
	{
		sceneLoader = sceneLoaderObject.GetComponent<SceneLoader>();
	}

	public void LoseLife(int retract)
	{
		otherPlayerPosition = GameObject.Find(otherPlayerName).transform.position;
		health -= retract;

		transform.position = new Vector3 (otherPlayerPosition.x, 20, otherPlayerPosition.z);

		if(health <= 0)
		{
			PlayerPrefs.SetInt ("playerID", playerID);
			StartCoroutine (End());
			transform.position = new Vector3 (otherPlayerPosition.x, otherPlayerPosition.y, otherPlayerPosition.z);
			Time.timeScale = 0.1f;
		}
	}

	IEnumerator End()
	{
		yield return new WaitForSeconds (0.5f);
		if(sceneLoader != null)
		{
			Time.timeScale = 1;
			sceneLoader.LoadScene (2);
		}
	}
}
