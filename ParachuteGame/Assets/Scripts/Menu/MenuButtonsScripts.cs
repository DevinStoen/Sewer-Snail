using UnityEngine;
using System.Collections;

public class MenuButtonsScripts : MonoBehaviour {

	public GUIStyle PlayButton;
	public GUIStyle RateButton;
	//Animator anim;
	public static bool Play;

	public GUIStyle AudioStyle;
	public GUIStyle TitleStyle;
	public GUIStyle devByStyle;

	public static int musicCounter;
	public GUIStyle AudioBtn;

	public float buttonDiff = Screen.height / 2f;
	public float buttonDiff2 = Screen.height / 6;



	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
		Play = false;

	}
	
	// Update is called once per frame
	void Update () {




		   }


	void OnGUI()
	{

		//Title So far
		TitleStyle.fontSize = Screen.width / 6;
		// /2-120, /2-240

		//title trial
		//GUI.Label (new Rect (Screen.width / 6.5f,Screen.height / 6.8f , 100, 50), "Sewer Snail", TitleStyle);

		//GUI.Label(new Rect (Screen.width / 2 - 120,Screen.height / 2 - 165 , 100, 50), "Developed by GlassPunch Studios", devByStyle);




		//Menu Buttons
		//menu buttons xpos = 40 originally
		if (GUI.Button (new Rect (Screen.width / 2.7f, Screen.height / 1.45f, Screen.width / 3.8f, Screen.height / 12), "", PlayButton)) 
		{
			//Screen.width / 2 - 135
			//Screen.height / 2 + 60/135
			//size 100 x 50
			Play = true;

			StartCoroutine(wait());

				}

		if (GUI.Button (new Rect (Screen.width / 2.7f, (Screen.height / 1.25f),Screen.width / 3.8f, Screen.height / 12), "", RateButton)) 
		{

		//	Application.OpenURL("market://details?id=com.RnRVertigo/");
			Application.OpenURL ("market://details?id=com.GlassPunch_Studios.Sewer_Snail");

				}




		//have this button in the retry menu to post high score! create post scores to leaderboard button
	//	if (GUI.Button (new Rect (Screen.width / 2.7f, Screen.height / 1.135f, Screen.width / 3.8f, Screen.height / 12), "", leaderBoard)) 
	//	{
	//		Social.localUser.Authenticate((bool success) => 
	//		                              {

	//			if(success)
	//			{
					//show the specific leaderboard.
	//				PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIrLmA68AEEAIQAQ");

	//			}
	//			else
	//			{

	//				Debug.Log ("Sorry, there was a problem logging in");
	//			}


	//		});
			//Application.LoadLevel (2);
			
	//	}
		//have the show leadrboards in the menu!


		//Audio Settings
		//sound on / off label???
		//GUI.Label (new Rect (63,Screen.height - 41 , 100, 50), "Sound On/Off", AudioStyle);

// 20 , scrn h - 50
		//scrn.height /18
		if(GUI.Button (new Rect(Screen.width / 14 ,Screen.height / 1.08f, Screen.width / 11, Screen.width / 11), "", AudioBtn))
		{
			musicCounter++;


		}

		if(musicCounter % 2 == 0){
			
			//AudioListener.volume = 0;
			AudioListener.volume = 0.9f;
		}
		else{
			
			//AudioListener.volume = 0.85f;
			AudioListener.volume = 0;
		}



	}


	IEnumerator wait()
	{

		yield return new WaitForSeconds(2);
		Application.LoadLevel(1);
	}

}
