using UnityEngine;
using System.Collections;

public class TiltTouchScript : MonoBehaviour {
	public float tiltAmount;
	
	private Quaternion rotateRight = Quaternion.Euler(0, 0, -2);
	private Quaternion rotateBack = Quaternion.Euler(0, 0, 2);
	private Quaternion rotateStart = Quaternion.Euler(0, 0, 0);
	
	public float rotSpeed = .25f;

	private Touch touch;




	Animator anim;
	
	void Start()
	{
		anim = GetComponent<Animator> ();

	}
	
	
	void Update () 
	{
		//touch = Input.GetTouch (0);


		if (Input.touchCount == 0) 
		{

			transform.rotation = Quaternion.Slerp(transform.rotation, rotateStart, rotSpeed);

		}



		if (Input.touchCount > 0) 
		{
						int i = 0;
						touch = Input.GetTouch (i);

						for (i = 0; i < Input.touchCount; i++) {
								if ((touch.position.x > Screen.width / 2)) {
			
										transform.rotation = Quaternion.Slerp (transform.rotation, rotateRight, rotSpeed);
			
								}
		
								if ((touch.position.x < Screen.width / 2)) {
			
										transform.rotation = Quaternion.Slerp (transform.rotation, rotateBack, rotSpeed);
								}
						}

				}


		
		if (PlayerMoveTouchScript.moveTOStart == true) 
		{
			//GameObject.Find("characterSnailPrefab").GetComponent<Animation>().Play("SnailIdle");
			//animation.Play ("SnailIdle");
			anim.SetBool("Fall", true);
		}

		//if (PlayerMoveTouchScript.backToZero) {

			//transform.rotation = Quaternion.Slerp(transform.rotation, rotateStart, rotSpeed);


				//}
		
	


		
		
		
	}


	
	

}
