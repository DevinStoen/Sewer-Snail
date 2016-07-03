using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {

	public AudioClip[] audioClip;

	public bool punchPlayed;
	public bool fartPlayed;
	public bool atMenuPlayed;
	public bool gameMusicPlayed;
	 
	// Use this for initialization
	void Start () {
		atMenuPlayed = false;
		punchPlayed = false;
		fartPlayed = false;
		gameMusicPlayed = false;
	}
	
	// Update is called once per frame
	void Update () {

				



				if (CollisionScript.hit && !punchPlayed) {
						PlaySound (0);
						punchPlayed = true;
				}

				if (CollisionScript.hit && !fartPlayed) {
			StartCoroutine(wait());

			fartPlayed = true;

				}

				if (PlayerMoveTouchScript.moveTOStart && !gameMusicPlayed) {

			//PlaySound (4);
			gameMusicPlayed = true;
			//audio.loop = true;

				}

				
		}
	void PlaySound(int clip){


						GetComponent<AudioSource>().PlayOneShot (audioClip [clip]);


		//audio.Play ();

	}






	IEnumerator wait()
	{
		yield return new WaitForSeconds(1.1f);

		if (RetryButton.Best) {
						PlaySound (3);
				} else {
						PlaySound (1);
				}
		}
}
