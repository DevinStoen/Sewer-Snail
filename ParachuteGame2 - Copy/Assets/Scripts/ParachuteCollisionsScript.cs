using UnityEngine;
using System.Collections;

public class ParachuteCollisionsScript : MonoBehaviour {

	public static bool Parahit;
	public GameObject DeadParachute;

	// Use this for initialization
	void Start () {
		Parahit = false;

		//parachute deploy trial.
		//sprender = gameObject.GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		if( CollisionScript.hit == true || Parahit == true)
		{

			Destroy (gameObject);
			Instantiate (DeadParachute, transform.position, Quaternion.identity);	


				
				//sprender.enabled= false;

		}

		}



		
	
	void OnCollisionEnter2D(Collision2D Playercollide){
		
		if (Playercollide.gameObject.tag == "Limit1") {
			//Debug.Log("Hit");

			Parahit = true;
		} 
		
	}

}
