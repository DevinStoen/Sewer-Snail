using UnityEngine;
using System.Collections;

public class ScoreScript : CollisionScript {

	public static int score;
	//public static int finalScore;

	public float timer = 0.0f;
	public int switchTimer;
	public Texture righthand;
	public Texture lefthand;


	string scoreString;
    public Font scoreFont;
	public GUIStyle scoreStyle;
	public GUIStyle titleStyle;


	public float alpha = 1.0f;
	public float alphaValue = 0.0f;


	//animate trial 
	//public float Xsize = 550;
	//public float Ysize = 630;
	public float labelFont = 40;
	public float labelXPos = 130;

	//public Texture tapToStart;
	// Use this for initialization
	void Start () 
	{
		score = 0;
		timer = 0;
		labelFont = 40;
	}
	
	// Update is called once per frame
	void Update () 
	{

		//animate font trial



		switchTimer  = (int)Time.time;


	
		scoreString = score.ToString();

		if (!hit && PlayerMoveTouchScript.moveTOStart == true) 
		{
			timer += Time.deltaTime;
						score = (int)timer;
			//finalScore = score;
				} 

	}

	void OnGUI()
	{
		//label animation
		//labelFont += Time.deltaTime;

		//if (labelFont > 42) {
		//	labelFont = 40;
			//labelXPos = 135;
		//}
		//switchTimer += (int) Time.deltaTime;


		GUI.Label(new Rect(10, 8, 100, 20),scoreString , scoreStyle);
		scoreStyle.fontSize = Screen.width / 6;

		if (!PlayerMoveTouchScript.moveTOStart) {

				//titleStyle.fontSize = (int)labelFont;
			titleStyle.fontSize = Screen.width / 9;
			//2 - 90
			//4+40
						GUI.Label (new Rect (Screen.width / 3.95f, Screen.height / 4 + 40, 550, 630), "Tap to Start!", titleStyle);



				} else 
		{

			GUI.color = new Color(1, 1, 1, alpha);
			alpha -= Mathf.Clamp01(Time.deltaTime);

			GUI.Label (new Rect (Screen.width / 3.95f, Screen.height / 4 + 40, 550, 630), "Tap to Start!", titleStyle);

				}



		//check!
		if (!PlayerMoveTouchScript.moveTOStart) {

						if (switchTimer % 2 == 0) {
								
				Graphics.DrawTexture (new Rect ((Screen.width) - Screen.width / 3, Screen.height / 2 + 30, Screen.width / 7, Screen.width / 6.8f), righthand);
			
						} else {
								
				Graphics.DrawTexture (new Rect (Screen.width / 5, Screen.height / 2 + 30, Screen.width / 7, Screen.width / 6.8f), lefthand);
						}

				} 






	}


}
