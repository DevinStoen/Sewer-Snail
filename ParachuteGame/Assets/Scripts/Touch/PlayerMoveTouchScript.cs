using UnityEngine;
using System.Collections;

public class PlayerMoveTouchScript : MonoBehaviour {

	private Touch touch; 

	public static bool moveTOStart;

	//public static bool backToZero; 
	
	public float acceleration = 6;
	public float maxSpeed = 6;
	public float dragAmount = 5;
	//public float decreaseSpeed = rigidbody.drag;
	//	public float turn = .5;
	void Start()
	{
		moveTOStart = false;
		

		
	}

	void Update () {
		
		//transform.position = Vector3(transform.position.y,0,0);

		//touch = Input.GetTouch (0); 

		var curSpeed = GetComponent<Rigidbody2D>().velocity.x;
		//var touch = Input.GetTouch(0).position;
		
		if (Input.touchCount > 0) {

			int i = 0;

			touch = Input.GetTouch (i); 
			//backToZero = false;
						//right
			for(i = 0; i < Input.touchCount; i++){

			if ((touch.position.x > Screen.width/2) && curSpeed < maxSpeed) {
			
								GetComponent<Rigidbody2D>().drag = 0;
								//transform.eulerAngles = new Vector3(0,0,0);
								//transform.Rotate(0,0,1);
			
								//gameObject.rigidbody.velocity.x = acceleration;
								GetComponent<Rigidbody2D>().AddForce (transform.right * acceleration);
								
								moveTOStart = true;
								//transform.Translate(Vector3.right * acceleration * Time.deltaTime);
			
						}
		
		
						//right
			//if (touch.phase == TouchPhase.Ended ) {
			
								//transform.Rotate(0,0,-1);
								//animation.Play ("tiltback");
			
								//slowDown ();
			
						//}


						//left
			if ((touch.position.x < Screen.width/2) && curSpeed > -maxSpeed) {
								//set the drag back to zero when the mouse is pressed
								GetComponent<Rigidbody2D>().drag = 0;
			
								//gameObject.rigidbody.velocity.x = -acceleration;
								GetComponent<Rigidbody2D>().AddForce (transform.right * -acceleration);
								moveTOStart = true;
								//transform.Translate(-Vector3.right * acceleration * Time.deltaTime);
						}
		
		
			}
		
		//NOT SURE IF TOUCH PHASE EVENS NEEDS TO BE APPLIED TWICE
		
						//left
						//if (Input.GetMouseButtonUp (0)) {
			
			
						//		slowDown ();
			
						//}






		//touchcount
				}
		//MIGHT HAVE TO PUT IT IN THIS
		//foreach (Touch touch in Input.touches) {
		//}
		if (touch.phase == TouchPhase.Ended ) {

			//backToZero = true;
			//transform.Rotate(0,0,-1);
			//animation.Play ("tiltback");
			
			slowDown ();
			
		}



		
		
	//update	
	}
	
	
	
	
	
	


	void slowDown(){
		//set a drag to Slow down player when the mouse is released.
		GetComponent<Rigidbody2D>().drag = dragAmount;
		
	}
	
	
	
	
	
	
}


	//if (Input.touchCount > 0)
	//{
		//var touch = Input.GetTouch[0];
		//if (touch.position.x < Screen.width/2)
		//{
			//DoLeftSideStuff();
		//}
		//else if (touch.position.x > Screen.width/2)
		//{
			//DoRightSideStuff();
		//}
	//}
//}
