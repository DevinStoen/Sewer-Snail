using UnityEngine;
using System.Collections;

public class CameraScript : CollisionScript 
{
	public bool Shaking; 
private float ShakeDecay;
public float ShakeIntensity;   
private Vector3 OriginalPos;
	Vector3 startPos;
	public float time;
void Start()
{
	Shaking = false;   
		hit = false;
		startPos = new Vector3(0, -6.64f, -10f);
}



void Update () 
{



		//player drop trial.
		if (PlayerMoveTouchScript.moveTOStart == true) 
		{

			if(transform.position.y < -6.64f)
			{
			float upMove = 7 * Time.deltaTime;
			
			transform.Translate (Vector3.up * upMove, Space.World);
			//animation.Play("SnailIdle");
			}
		}







		if(hit)
		{
			DoShake();  

			time += Time.deltaTime;
		}
	if (ShakeIntensity > 0 && time <= 0.2) {
						transform.position = OriginalPos + Random.insideUnitSphere * ShakeIntensity;
		
		
						ShakeIntensity -= ShakeDecay;
				} else if (time > 0.2) {

			transform.position = startPos;

				}
	
	
}


     

public void DoShake()
{
	OriginalPos = transform.position;
	
	
	ShakeIntensity = 0.08f;
	ShakeDecay = .01f;
	Shaking = true;
}  
	}
