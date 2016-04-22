using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	public int lives = 3;
	public int bricks = 20;
	public float resetDelay = 1f;
	public Canvas LivesText;
	public GameObject GameOver;
	public GameObject YOUDIDIT;
	public GameObject bricksPrefab;
	public GameObject paddle;
	public GameObject deathParticles;
	public static GM instance = null;

	private GameObject clonePaddle;

	// Use this for initialization
	void Start () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		Setup();
	}

	public void Setup()
	{
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject;
		Instantiate (bricksPrefab, transform.position, Quaternion.identity);
	
	}
	// Update is called once per frame
	void CheckGameOver () 
	{
		if (bricks < 1) 
		{
			YOUDIDIT.SetActive (true);
			Time.timeScale = .25f;
			Invoke ("Reset", resetDelay);
		}

		if (lives < 1) {
			GameOver.SetActive (true);
			Time.timeScale = .25f;
			Invoke ("Reset", resetDelay);
		}

		void Reset()
		{
			Time.timeScale = 1f
			Application.LoadLevel(Application.loadedLevel);
		}

		public void LoseLife()
		{
			Lives==; 
			LivesText.text = "Lives: " + lives;
			Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
			Destroy(clonePaddle);
			Invoke ("SetupPaddle", resetDelay);
			CheckGameOver();
		}

		void SetupPaddle()
		{
			clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject;
		}

		public void DestroyCube()
		{
			bricks--;
		CheckGameOver ();
	}
}
}