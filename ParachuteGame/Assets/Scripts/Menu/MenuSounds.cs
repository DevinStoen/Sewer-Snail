using UnityEngine;
using System.Collections;

public class MenuSounds : MonoBehaviour {

	public AudioClip[] audioClip1;
	

	public bool menubtnPlayed;
	public bool atMenuPlayed;
	public bool toiletPlayed;
	
	// Use this for initialization
	void Start () {
		atMenuPlayed = false;
		menubtnPlayed = false;
		toiletPlayed = false;
	}
	
	// Update is called once per frame
	void Update () {
		

		
		if (!MenuButtonsScripts.Play && !atMenuPlayed) {
		
			PlaySound (0);
			atMenuPlayed = true;
			
		}

	if (MenuButtonsScripts.Play && !menubtnPlayed) {
			PlaySound (1);
			//PlaySound(2);
			menubtnPlayed = true;

				}
		//if (MenuButtonsScripts.Play && !toiletPlayed) {
		//	PlaySound(2);
			//toiletPlayed = true;
			//	}

	}


	void PlaySound(int clip){
		
		
		GetComponent<AudioSource>().PlayOneShot (audioClip1 [clip]);
		
		
		//audio.Play ();
		
	}
	

}
