using UnityEngine;
using System.Collections;

public class Cubes : MonoBehaviour {

	public GameObject brickParticle;

	void onCollisionEnter (Collision other)
	{
		Instantiate (brickParticle, transform.position, Quaternion.identity);
		GM.instance.DestroyCube ();
		Destroy (gameObject);


	}
}
