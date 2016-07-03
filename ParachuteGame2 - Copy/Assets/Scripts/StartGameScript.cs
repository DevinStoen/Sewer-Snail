using UnityEngine;
using System.Collections;

public class StartGameScript : MonoBehaviour {

	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	
	    public float SpawnValue = -31;
		public GameObject[] selectorArr;
		public int randomstartInt;
	//Update is called once per frame
	
		void Start()
	{
	
		randomstartInt = Random.Range(0,3);
	
		selectorArr = new GameObject[3];
	
	selectorArr [0] = prefab1;
	selectorArr [1] = prefab2;
	selectorArr [2] = prefab3;
	
	Instantiate ( selectorArr[randomstartInt], new Vector3 (0, SpawnValue, 2.5f),Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
