using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {


	public Texture2D RetryButton = null;
	public GameObject DeadSnail;
	static public bool hit;



	void Start()
	{
		hit = false;

		}
	void Update()
	{
		if (ParachuteCollisionsScript.Parahit == true) 
		{
			hit = true;

				}


		if (hit) 
		{

			Destroy (gameObject);
			Instantiate (DeadSnail, transform.position, Quaternion.identity);

				}

	}


		void OnCollisionEnter2D(Collision2D Playercollide)
	{

		if (Playercollide.gameObject.tag == "Limit1") {
			//Debug.Log("Hit");
			//Destroy (gameObject);
			//Instantiate (DeadSnail, transform.position, Quaternion.identity);	

			hit = true;
		} 

		}


}