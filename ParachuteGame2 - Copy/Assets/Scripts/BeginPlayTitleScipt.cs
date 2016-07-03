using UnityEngine;
using System.Collections;

public class BeginPlayTitleScipt : MonoBehaviour {
	public float alphaValue = 1.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CollisionScript.hit) {
						//Fade.use.Alpha (guiTexture, 1.0, 0.0, 3.0);
				}
	}

	void OnGUI()
	{
		if (CollisionScript.hit) 
		{
						GUI.color = new Color (1, 1, 1, alphaValue);
						alphaValue -= Mathf.Clamp01 (Time.deltaTime);
			//this.gameObject;

				}


	}
}
