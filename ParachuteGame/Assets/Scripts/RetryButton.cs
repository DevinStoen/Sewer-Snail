using UnityEngine;
using System.Collections;

public class RetryButton : CollisionScript {

	//for loop int
	public int badgeNum;

	public int ButtonMove = 10;
	public GUIStyle customButton;
	public GUIStyle customButton1;

	//trophy room
	public GUIStyle trophyButton;



	public static bool greyBadgeamt;
	public static bool bronzeBadgeamt;
	public static bool silverBadgeamt;
	public static bool goldBadgeamt;


	public Texture gameOver;
	public Texture FadeinScene;

	public Texture deathFlash;

	//badge temp
	public Texture badgeEarned;
	//badge textures
	public Texture level1, level2, level3, level4, levelloser;

	//for loop array
	//public Texture[] badgeArray;


	public GameObject particles;
		

	// Use this for initialization
	public static float alphaValue = 0.0f;
	//public float alphaValue2;

	public float fadein = 1.0f;
	public float WidthAmt = 100;
	public float HeightAmt = 100;
	public float time;

	public string scoreFin;
	public int scoreFinal;

	public GUIStyle guiGMScoreStyle;
	public GUIStyle BestSO;

	public int highScore;
	//high score boolean
	public static bool Best;

	public float guiFadeTime;

	//create an instance of the trophy rm script.
	TrophyRoomScript trophyscript = new TrophyRoomScript();
	
	//public static bool RetryPressed;

	void Start () 
	{
		//RetryPressed = false;
		hit = false;
		Best = false;

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//PlayerPrefs.SetInt("HighScore", 0);


		//125
		if (ScoreScript.score >= 125) 
		{
			//goldBadgeamt = true;
						badgeEarned = level4;
				} 
		//75
		else if (ScoreScript.score >= 75) 
		{
			//silverBadgeamt = true;
						badgeEarned = level3;
				} 
		//50
		else if (ScoreScript.score >= 50) 
		{
			//bronzeBadgeamt = true;
						badgeEarned = level2;
				} 
		//25
		else if (ScoreScript.score >= 25) 
		{
			//greyBadgeamt = true;
						badgeEarned = level1;
				} 
		else if (ScoreScript.score >= 0)
		{

						badgeEarned = levelloser;
				}



	if (hit) 
		{ 


			time += Time.deltaTime;

			if (ScoreScript.score >= 125) 
			{
				goldBadgeamt = true;
				bronzeBadgeamt = false;
				greyBadgeamt = false;
				silverBadgeamt = false;
				trophyscript.updateTrophies();
			} 
			//75
			else if (ScoreScript.score >= 75) 
			{
				silverBadgeamt = true;
				bronzeBadgeamt = false;
				greyBadgeamt = false;
				goldBadgeamt = false;
				trophyscript.updateTrophies();
			} 
			//50
			else if (ScoreScript.score >= 50) 
			{
				bronzeBadgeamt = true;
				greyBadgeamt = false;
				goldBadgeamt = false;
				silverBadgeamt = false;
				trophyscript.updateTrophies();
	
			} 
			//25
			else if (ScoreScript.score >= 25) 
			{

				greyBadgeamt = true;
				goldBadgeamt = false;
				silverBadgeamt = false;
				bronzeBadgeamt = false;
				trophyscript.updateTrophies();
			}
			else if(ScoreScript.score >= 0)
			{
				greyBadgeamt = false;
				goldBadgeamt = false;
				silverBadgeamt = false;
				bronzeBadgeamt = false;
				trophyscript.updateTrophies();
				
			}

	}

						

		//save high score before load new game.
		if(ScoreScript.score > PlayerPrefs.GetInt("HighScore"))
		{
			
			PlayerPrefs.SetInt("HighScore", ScoreScript.score);
			highScore = ScoreScript.score;
			Best = true;
			
		}
		else
		{
			highScore = PlayerPrefs.GetInt ("HighScore");
			//Best = false;
				
		}

	}

	void OnGUI()
	{

		//time = Time.deltaTime;

		//dead GUI 
		if (hit && time > 1) 
		{

		
			//GUI.color = new Color(originalColor.r,originalColor.g,originalColor.b,

			GUI.color= new Color(1,1,1,alphaValue);
			alphaValue += Mathf.Clamp01 (Time.deltaTime);
			//320X350

			///2 - 60, /4 + 10
			Graphics.DrawTexture(new Rect(Screen.width/ 20f , Screen.height / 3.9f, Screen.width / 1.1f, Screen.height / 1.7f), gameOver);




				
			//for(int i = 1; i == badgeNum; i++)
			//{
				//put in badge array for the for loop
			Graphics.DrawTexture(new Rect(Screen.width/1.37f, Screen.height / 2.46f, Screen.width / 7f, Screen.width / 7f), badgeEarned );

			//	StartCoroutine(wait());

			//}


			//GUI.color.a += Time.deltaTime * fadein;

			//score display
			guiGMScoreStyle.fontSize = Screen.width / 10;
			// /2-20,/4+110
			// /2-20,/4+155
			GUI.Label (new Rect(Screen.width/2.2f, Screen.height / 2.35f, 285, 315),ScoreScript.score.ToString(),guiGMScoreStyle );

			GUI.Label (new Rect(Screen.width/2.2f, Screen.height / 2f, 255, 315),highScore.ToString(),guiGMScoreStyle );


			//may have to change for touches. Touch button?
			if (GUI.Button (new Rect ((Screen.width / 2) - Screen.width / 2.8f, Screen.height / 2 + Screen.height/6 + 10, Screen.width / 3.8f, Screen.height / 12), "", customButton)) {
						//RetryPressed = true;


				Application.LoadLevel (1);
				//100x50 size
				//screen.width/2 - 142 / + 40
						}

			if (GUI.Button (new Rect ((Screen.width/2) + Screen.width / 11, Screen.height / 2 + Screen.height/6 + 10, Screen.width / 3.8f, Screen.height / 12), "", customButton1)) {


				Application.LoadLevel (0);
				
			}

			if (GUI.Button (new Rect (Screen.width / 2.52f,Screen.height / 1.23f,Screen.width / 5,Screen.height / 8), "", trophyButton)) 
			{
				
				Application.LoadLevel (2);
				
			}



	//	if (GUI.Button (new Rect ((Screen.width/2) + Screen.width / 11, Screen.height / 1.21f, Screen.width / 3.8f, Screen.height / 12), "", shareButton)) 
	//	{
				//if the share button is pressed, authenticate google play account
			//	Social.localUser.Authenticate((bool success) => 
				                            //  {
					
				//	if(success)
				//	{
						//post high score code! using UnityEngine.SocialPlatforms;
				//		Social.ReportScore(PlayerPrefs.GetInt("HighScore"), "CgkIrLmA68AEEAIQAQ", (bool successPost) => {

				//			if(successPost)
				//			{
				//				Debug.Log ("posted!");
				//			}
				//			else
				//			{
				//				Debug.Log ("sorry there was a problem posting the score");
				//			}
							// handle success or failure
							//Debug.Log("Success!");
			//			});
						
				//	}

			//		else{
						
			//			Debug.Log ("Sorry, there was a problem logging in");
			//		}
					
					
			//	});
				//Application.LoadLevel (2);
				
		//	}




			if(Best)
			{
				BestSO.fontSize = Screen.width / 20;
				GUI.Label (new Rect(Screen.width/2.5f, Screen.height / 2.6f, 550, 630),"High Score!",BestSO );


			}

		
			}


		if (hit && time < 0.08f)
		{

			Graphics.DrawTexture(new Rect(0, 4.5f, Screen.width, Screen.height), deathFlash);



				}




				}



	
//	}

}