using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    private float score;
    // Use this for initialization
	void Start()
	{
		InvokeRepeating ("Timer", 1f, 1f);
	}

	void Timer()
	{
		score++; // every second add 1 to score.
	}

    public void SendScore()
    {
            StartCoroutine(HandleEnterScore(score));
    }

    public IEnumerator HandleEnterScore(float score)
    {
        //Create the url of the script with the variables that will be written to the database.
        string score_url = "http://19742.hosts.ma-cloud.nl/Database.php" + "?score=" + score;

        //Go to the url and get whatever the url is printing out
        WWW webRequest = new WWW(score_url);

        //wait until the site is done loading before continueing.
        yield return webRequest;
    }
}
