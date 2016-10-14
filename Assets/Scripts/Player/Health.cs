using UnityEngine;
using System.Collections;
public class Health : MonoBehaviour {
	[SerializeField] private int health;
	[SerializeField] private string otherPlayerName;
	[SerializeField] private GameObject sceneLoaderObject;
	[SerializeField] private int playerID;

	private SceneLoader sceneLoader;
	private Vector3 otherPlayerPosition;
	//dead animation;
	private Animator anim;
	private bool isDead = false;
	private PlayerController playerController;
	void Awake()
	{
		playerController = GetComponent<PlayerController> ();
		anim = GetComponent<Animator> ();
		sceneLoader = sceneLoaderObject.GetComponent<SceneLoader>();
		playerController.enabled = true;
		isDead = false;
	}
	public void LoseLife(int retract)
	{
		otherPlayerPosition = GameObject.Find(otherPlayerName).transform.position; // check witch player lost a life.
		health -= retract;//removes the amount of lifes.
		transform.position = new Vector3 (otherPlayerPosition.x, 10, otherPlayerPosition.z);// if there is an life lost set there position above the other player.
		if(health <= 0)
		{
			PlayerPrefs.SetInt ("playerID", playerID); // Sets the player number that won in the PlayerPrefs.
			StartCoroutine (End());
			//Dead animation
			playerController.enabled = false; // Disables the player controller of the player who is dead.
			isDead = true;
			anim.SetBool ("Dead", isDead); //sets the animator on the dead animation.
			transform.position = new Vector3 (otherPlayerPosition.x, otherPlayerPosition.y, otherPlayerPosition.z);// Sets the dead player on the screen to indicate that it is over.
		}
	}

	public int GetHealth// A getter to be able to get the health value in other scripts.
	{
		get
		{
			return health;
		}
	}

	IEnumerator End()
	{
		yield return new WaitForSeconds (3f);
		if(sceneLoader != null)// for if there is no script attached to it
		{
			sceneLoader.LoadScene (3);
		}
	}
}