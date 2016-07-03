using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {

	public Texture2D FadeTexture;
	public float fadeSpeed = 0.8f;

	private int depth = -1000;
	private float alpha = 1.0f;
	public int fadedir = -1;
	// Use this for initialization

	static int LoadedLevel;

	void OnGUI()
	{
		alpha += fadedir * fadeSpeed * Time.deltaTime;

		alpha = Mathf.Clamp01 (alpha);

		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = depth;
		GUI.DrawTexture( new Rect(0,0,Screen.width,Screen.height), FadeTexture);


	
	
	}




	public float BeginFade(int direction)
	{
		fadedir = direction;
		return(fadeSpeed);


	}


	void OnLevelWasLoaded()
	{
	

						BeginFade (-1);
				
	}

	void Update(){



		if (MenuButtonsScripts.Play && Application.loadedLevel == 0) {

			StartCoroutine(wait());
			//BeginFade(1);
				}

	}

	IEnumerator wait()
	{
		
		yield return new WaitForSeconds(1.5f);
		BeginFade(3);
	}


}
