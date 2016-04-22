using UnityEngine;
using System.Collections;

public class Ifstatement : MonoBehaviour 
{
	float BallDistance = 100.0f;
	float toosoonDistance = 4.0f;
	float toolateDistance = 1.0f;

	// Use this for initialization
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			Swing();

		BallDistance -= Time.deltaTime * 8f;
	}

	void Swing ()
	{
		if (BallDistance > toosoonDistance)
		{
			Debug.Log ("Swung too soon");
		} 
		else if (BallDistance < toolateDistance) 
		{
			Debug.Log ("Swung too late");
		} else 
		{
			Debug.Log ("Homerun");
		}
		// Update is called once per frame

		{

		}
	}
}