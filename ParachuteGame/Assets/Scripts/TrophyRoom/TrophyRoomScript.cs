using UnityEngine;
using System.Collections;

public class TrophyRoomScript : MonoBehaviour {



	public GUIStyle mainMenu;

	public GUIStyle guiGMScoreStyle;

	public int greyBadges;
	public int bronzeBadges;
	public int silverBadges;
	public int goldBadges;

	public Texture trophyBoard;

	// Use this for initialization
	public bool addOne;

		
	// Update is called once per frame
	void Update () {

		//debug Only!
		//PlayerPrefs.SetInt ("greyTimesEarned", 0);
		//PlayerPrefs.SetInt ("bronzeTimesEarned", 0);
		//PlayerPrefs.SetInt ("silverTimesEarned", 0);
		//PlayerPrefs.SetInt ("goldTimesEarned", 0);


		guiGMScoreStyle.fontSize = Screen.width / 10;


		goldBadges = PlayerPrefs.GetInt ("goldTimesEarned");
		silverBadges = PlayerPrefs.GetInt ("silverTimesEarned");
		bronzeBadges = PlayerPrefs.GetInt ("bronzeTimesEarned");
		greyBadges = PlayerPrefs.GetInt ("greyTimesEarned");
			
	}

	void OnGUI()
	{
		Graphics.DrawTexture(new Rect(Screen.width/ 8.8f , Screen.height / 4.41f, Screen.width / 1.3f, Screen.height / 1.6f), trophyBoard);

		//grey amount
		GUI.Label (new Rect(Screen.width/3.5f, Screen.height / 2.19f, 285, 315),greyBadges.ToString(),guiGMScoreStyle );

		//bronze amount
		GUI.Label (new Rect(Screen.width/1.495f, Screen.height / 2.19f, 285, 315),bronzeBadges.ToString(),guiGMScoreStyle );


		//silver amount
		GUI.Label (new Rect(Screen.width/3.5f, Screen.height / 1.38f, 285, 315),silverBadges.ToString(),guiGMScoreStyle );

		//gold amount
		GUI.Label (new Rect(Screen.width/1.495f, Screen.height / 1.38f, 285, 315),goldBadges.ToString(),guiGMScoreStyle );
		
		if (GUI.Button (new Rect (Screen.width / 2.7f, Screen.height/1.15f, Screen.width / 3.8f, Screen.height / 12), "", mainMenu)) {
			//addOne = false;
			Application.LoadLevel (0);

			
		}

	}

	public void updateTrophies()
	{

		//trophy amount assignment
		if (RetryButton.goldBadgeamt && !addOne) 
		{
			//RetryButton.goldBadgeamt = goldBadges2;
			//goldBadges += 1;
			PlayerPrefs.SetInt ("goldTimesEarned", PlayerPrefs.GetInt("goldTimesEarned") + 1);
			addOne = true;
		}
		if (RetryButton.silverBadgeamt && !addOne) 
		{
			//RetryButton.silverBadgeamt = silverBadges2;
			//silverBadges += 1;
			PlayerPrefs.SetInt ("silverTimesEarned", PlayerPrefs.GetInt("silverTimesEarned") + 1);
			addOne = true;
		}
		if (RetryButton.bronzeBadgeamt && !addOne) 
		{
			
			//RetryButton.bronzeBadgeamt = bronzeBadges2;
			//bronzeBadges += 1;
			PlayerPrefs.SetInt ("bronzeTimesEarned", PlayerPrefs.GetInt("bronzeTimesEarned") + 1);
			addOne = true;
		}
		
		
		if (RetryButton.greyBadgeamt && !addOne) 
		{
			//RetryButton.greyBadgeamt = greyBadges2;
			//greyBadges += 1;
			PlayerPrefs.SetInt ("greyTimesEarned", PlayerPrefs.GetInt("greyTimesEarned") + 1);
			addOne = true;
		}


	}
}
