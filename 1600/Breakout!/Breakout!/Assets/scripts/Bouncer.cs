using UnityEngine;
using System.Collections;

public class Bouncer : MonoBehaviour {

	public float bouncerSpeed = 1f;

	private Vector3 playerPos = new Vector3 (0, -9.5f, 0);

	
 void Update ()	  
	{
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * bouncerSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -19f, 19f), -9.5f, -0f);
	transform.position = playerPos;
	}

}