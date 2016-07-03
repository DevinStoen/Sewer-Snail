using UnityEngine;
using System.Collections;

public class tiltScript : MonoBehaviour {

	public float tiltAmount;

	private Quaternion rotateRight = Quaternion.Euler(0, 0, -2.5f);
	private Quaternion rotateBack = Quaternion.Euler(0, 0, 2.5f);
	private Quaternion rotateStart = Quaternion.Euler(0, 0, 0);

	public float rotSpeed = .25f;

	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();

	}


	void Update () 
	{
	
		if (!Input.GetMouseButton (1) && !Input.GetMouseButton (0)) 
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, rotateStart, rotSpeed);
		
				}


		if (Input.GetMouseButton(1))
		{
	
			transform.rotation = Quaternion.Slerp(transform.rotation, rotateRight, rotSpeed);

		}

		if (Input.GetMouseButton(0))
		{
	
			transform.rotation = Quaternion.Slerp(transform.rotation, rotateBack, rotSpeed);
		}


		if (PlayerMoveScript.moveTOStart == true) 
		{
			//GameObject.Find("characterSnailPrefab").GetComponent<Animation>().Play("SnailIdle");
			//animation.Play ("SnailIdle");
			anim.SetBool("Fall", true);
				}



		
	
		}



	}

