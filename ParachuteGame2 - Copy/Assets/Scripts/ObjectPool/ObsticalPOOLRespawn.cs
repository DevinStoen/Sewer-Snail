using UnityEngine;
using System.Collections.Generic;

public class ObsticalPOOLRespawn : MonoBehaviour {

	
	public GameObject StartPrefab;
	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject prefab4;
	public GameObject prefab5;
	public GameObject prefab6;
	public GameObject prefab7;
	public GameObject temp;

	public static int spawnCount;

	public GameObject[] InfiniteArr;
	public GameObject activate;

	public int poolSize = 7;

	public static int randomChooseInt;
	
	public float spawnValue = -29;

	public  int StartRandom;
	//public List<GameObject>[] pool;
	
	void OnTriggerEnter2D(Collider2D col){
		
		if (col.gameObject.tag == "Level") {
			//Debug.Log("Destroy");
			//Destroy (gameObject);
			col.gameObject.SetActive(false);


			spawnCount++;
			
			randomChooseInt = Random.Range (0, poolSize);
	

			//activate = GameObject.Find("PipePrefab");
	//InfiniteArr [randomChooseInt].SetActive(true);
			//activate.gameObject.SetActive(true);

			SpawnLevel(randomChooseInt);

			//activate = GameObject.Find ("prefab" + randomChooseInt).GetComponent<gameObject>();
	//InfiniteArr [randomChooseInt].transform.position = (new Vector3 (0, spawnValue, 2.5f));
			//activate.gameObject.SetActive (true);
			//SpawnLevel(randomChooseInt);
		//	activate.transform.position = (new Vector3 (0, spawnValue, 2.5f));
			//activate.transform.position = (new Vector3 (0, spawnValue, 2.5f));
//			InfiniteArr [randomChooseInt], new Vector3 (0, spawnValue, 2.5f), Quaternion.identity).SetActive(true);
			//InfiniteArr[randomChooseInt].rigidbody.MovePosition(new Vector3 (0, spawnValue, 2.5f));
			
			//ObsticalPOOLRespawn activate = GameObject.Find ("temp").GetComponent < ObsticalPOOLRespawn >();
			//activate.SpawnLevel(randomChooseInt);
		}  
		
	}


	
	// Use this for initialization
	void Start () {


		InfiniteArr = new GameObject[poolSize + 1];
		


		SetPrefabs();
		Instantiate ();


		StartRandom = Random.Range (0, 3);

	
		SpawnLevel (StartRandom);

		
	}

	void Instantiate(){

		Instantiate (StartPrefab as GameObject);
		StartPrefab.transform.position = (new Vector3 (0, -6, 2.5f));
		StartPrefab.transform.rotation = this.transform.rotation;
		


		GameObject temp;
		
		for (int i = 0; i < poolSize; i++) {
			
			temp = (GameObject)Instantiate(InfiniteArr[i]);
			temp.transform.parent = temp.transform;
			temp.transform.rotation = temp.transform.rotation;
			
			//InfiniteArr[i].transform.parent = gameObject.transform;
			InfiniteArr[i].SetActive(false);
			
		}


		}


	// Update is called once per frame
	void Update () {

		//transform.eulerAngles=new Vector3(0,transform.eulerAngles.y,transform.eulerAngles.z);
		//ObjectRespawn activate 



	}

	void reactivateLevel()
	{
	


	}


	void SetPrefabs()
	{

		//7
		InfiniteArr [0] = prefab1;
		InfiniteArr [1] = prefab2;
		InfiniteArr [2] = prefab3;
		InfiniteArr [3] = prefab4;
		InfiniteArr [4] = prefab5;
		InfiniteArr [5] = prefab6;
		InfiniteArr [6] = prefab7;


}

	public GameObject SpawnLevel(int level)
	{


						InfiniteArr [level].SetActive (true);
						InfiniteArr [level].transform.position = (new Vector3 (0, spawnValue, 2.5f));
				
		return InfiniteArr[level];

	}
}