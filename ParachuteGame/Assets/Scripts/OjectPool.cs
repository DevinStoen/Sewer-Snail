using UnityEngine;
using System.Collections;

public class OjectPool : MonoBehaviour {
	
	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject prefab4;
	public GameObject prefab5;
	public GameObject prefab6;
	public GameObject prefab7;
	public GameObject prefab8;
	public GameObject prefab9;
	public GameObject prefab10;
	public GameObject prefab11;
	public GameObject prefab12;
	public GameObject prefab13;
	public GameObject prefab14;
	public GameObject prefab15;
	public GameObject prefab16;
	
	
	//easy prefabs
	public GameObject easyPrefab1, easyPrefab2, easyPrefab3, easyPrefab4, easyPrefab5, easyPrefab6, easyPrefab7;
	
	public GameObject startPrefab;
	

	int i = 0;
	public int startRange, endRange;
	
	
	public GameObject[] InfiniteArr;
	public int randomChooseInt;
	public int secondLevel;
	
	public float spawnValue = -30;
	
	public int prefabLength = 8;

	public bool spawn;
	public bool firstSpawn;

	public int nextLevelInt;

	void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.gameObject.tag == "Level") 
		{
			//Debug.Log("Destroy");
			//Destroy (gameObject);
			
			int destroyedLevelInt = i;
			
			col.gameObject.SetActive(false);
			
			
			nextLevelInt = Random.Range (startRange,endRange);
			
			
			while(nextLevelInt == destroyedLevelInt)
			{
				nextLevelInt = Random.Range (startRange,endRange);
			}
			
			//randomChooseInt = nextLevelInt;
			//randomChooseInt = Random.Range (0, 16);
			
			//levelSpawn(nextLevelInt);
			spawn = true;
		}
		
		
	}

	void initialInstantiate()
	{
		for(int i = 0; i < InfiniteArr.Length; i++)
		{
			//Instantiate[i] = Instantiate as GameObject;
			//Instantiate (InfiniteArr [i], new Vector3 (0, spawnValue, 2.5f), Quaternion.identity);
			//Instantiate (InfiniteArr [i], new Vector3 (0, spawnValue, 2.5f), Quaternion.identity);

			InfiniteArr[i] = Instantiate (InfiniteArr[i]) as GameObject;
			InfiniteArr[i].SetActive(false);
		
		}




	}





	// Use this for initialization
	void Start () 
	{
		Instantiate (startPrefab as GameObject);
		startPrefab.transform.position = (new Vector3 (0, -6, 2.5f));
		
		InfiniteArr = new GameObject[23];
		
		InfiniteArr [0] = prefab1;
		InfiniteArr [1] = prefab2;
		InfiniteArr [2] = prefab3;
		InfiniteArr [3] = prefab4;
		InfiniteArr [4] = prefab5;
		InfiniteArr [5] = prefab6;
		InfiniteArr [6] = prefab7;
		InfiniteArr [7] = prefab8;
		InfiniteArr [8] = prefab9;
		InfiniteArr [9] = prefab10;
		InfiniteArr [10] = prefab11;
		InfiniteArr [11] = prefab12;
		InfiniteArr [12] = prefab13;
		InfiniteArr [13] = prefab14;
		InfiniteArr [14] = prefab15;
		InfiniteArr [15] = prefab16;
		
		//easy prefabs.
		InfiniteArr [16] = easyPrefab1;
		InfiniteArr [17] = easyPrefab2;
		InfiniteArr [18] = easyPrefab3;
		InfiniteArr [19] = easyPrefab4;
		InfiniteArr [20] = easyPrefab5;
		InfiniteArr [21] = easyPrefab6;
		InfiniteArr [22] = easyPrefab7;
		
		secondLevel = Random.Range (16, 19);
		
		//levelSpawn (secondLevel);


		firstSpawn = true;
		
		    initialInstantiate();
	}
	






	void Update () 
	{
		transform.eulerAngles=new Vector3(0,transform.eulerAngles.y,transform.eulerAngles.z);
		
		
		//game gets harder!
		if (ScoreScript.score > 10) 
		{
			startRange = 0;
			endRange = 16;
			
		} else 
		{
			startRange = 16;
			endRange = 23;
		}


		if (firstSpawn) 
		{
						levelSpawn (secondLevel);
				}

		if (spawn) 
		{
						levelSpawn (nextLevelInt);
				}
		
	}
	






	
	private void levelSpawn(int level)
	{
		i = level;


		//if (InfiniteArr [i].SetActive = false) 
		//{

		if (!InfiniteArr [level].activeSelf) 
		{
						InfiniteArr [level].transform.position = new Vector3 (0, spawnValue, 2.5f);
						InfiniteArr [level].gameObject.SetActive (true);
			spawn = false;
			firstSpawn = false;
			//return InfiniteArr[level];
				}
			//InfiniteArr[level].transform.position = new Vector3(0, spawnValue, 2.5f);
						
				//}
	}
	
	



}
