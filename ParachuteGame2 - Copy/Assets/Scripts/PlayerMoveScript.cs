using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {
	//shine clense your soul
   
	//make sure the player clicks to start.
	public static bool moveTOStart;


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

				
				var curSpeed = rigidbody2D.velocity.x;
				
						



						if (Input.GetMouseButton (1) && curSpeed < maxSpeed) {
								
								rigidbody2D.drag = 0;
			//transform.eulerAngles = new Vector3(0,0,0);
			//transform.Rotate(0,0,1);

						//gameObject.rigidbody.velocity.x = acceleration;
						rigidbody2D.AddForce(transform.right * acceleration);
			moveTOStart = true;
						//transform.Translate(Vector3.right * acceleration * Time.deltaTime);

						}

						





		if (Input.GetMouseButtonUp (1)) {
			              
			//transform.Rotate(0,0,-1);
			//animation.Play ("tiltback");

			
			slowDown ();
								
						}

						if (Input.GetMouseButton (0) && curSpeed > -maxSpeed) {
								//set the drag back to zero when the mouse is pressed
								rigidbody2D.drag = 0;
						
								//gameObject.rigidbody.velocity.x = -acceleration;
								rigidbody2D.AddForce(transform.right * -acceleration);
			moveTOStart = true;
								//transform.Translate(-Vector3.right * acceleration * Time.deltaTime);
		}
		
						





		if (Input.GetMouseButtonUp (0)) {

		
			slowDown ();

				}





		}






	void slowDown(){
		//set a drag to Slow down player when the mouse is released.
		rigidbody2D.drag = dragAmount;

	}






}
