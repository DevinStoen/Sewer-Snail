using UnityEngine;
using System.Collections;

public class disapearScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer>().enabled = false;
	}
}
