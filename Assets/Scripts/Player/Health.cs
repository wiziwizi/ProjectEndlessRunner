using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[SerializeField] private int health;
	[SerializeField] private string otherPlayerName;

	private SceneLoader sceneLoader;
	[SerializeField] private GameObject sceneLoaderObject;

	private Vector3 otherPlayerPosition;

	[SerializeField] private int playerID;

	//dead animation;
	private Animator anim;
	private bool isDead = false;

	void Awake()
	{
		anim = GetComponent<Animator> ();
		sceneLoader = sceneLoaderObject.GetComponent<SceneLoader>();
		isDead = false;
	}

	public void LoseLife(int retract)
	{
		otherPlayerPosition = GameObject.Find(otherPlayerName).transform.position;
		health -= retract;

		transform.position = new Vector3 (otherPlayerPosition.x, 10, otherPlayerPosition.z);

		if(health <= 0)
		{
			PlayerPrefs.SetInt ("playerID", playerID);
			StartCoroutine (End());
			//Dead animation
			isDead = true;
			anim.SetBool ("Dead", isDead);
			transform.position = new Vector3 (otherPlayerPosition.x, otherPlayerPosition.y, otherPlayerPosition.z);
		}
	}

	IEnumerator End()
	{
		yield return new WaitForSeconds (5f);
		if(sceneLoader != null)
		{
			sceneLoader.LoadScene (2);
		}
	}
}
