using UnityEngine;
using System.Collections;

public class ScrollScript : CollisionScript {

	public float speed;

	//public float timer;
	//hit.GetComponents<CollisionScript>;
	void Start()
	{
		hit = false;


		}
	

	void Update () {
		//change speed trial		
	//	if (ScoreScript.score == 4) {

			//speed = 7.5f;
			//	}





		if (!hit && PlayerMoveTouchScript.moveTOStart == true) 
		{
						float upMove = speed * Time.deltaTime;

						transform.Translate (Vector3.up * upMove, Space.World);
			//animation.Play("SnailIdle");
				}

		}






}
