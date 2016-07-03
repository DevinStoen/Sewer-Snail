using UnityEngine;
using System.Collections;

public class MenuHandScript : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
		
		//anim.SetBool ("PressedPlay", false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (MenuButtonsScripts.Play) 
		{
			anim.SetBool("PressedPlay",true);
			
		}
		
		if (!MenuButtonsScripts.Play) 
		{
			anim.SetBool ("PressedPlay", false);
			
		}
	}
}
