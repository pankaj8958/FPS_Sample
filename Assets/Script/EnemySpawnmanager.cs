using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnmanager : MonoBehaviour {

	public GameObject enemyPrefab;
	public Transform playerObj;
	GameObject enemyObj = null;
	Transform enemyTransform;
	public Transform[] spawnLocation;

	public static EnemySpawnmanager instance = null;

	void Awake () {
		if (instance == null) {
			instance = this.GetComponent<EnemySpawnmanager>();
		} else {
			Destroy (this.gameObject);
		}
		DontDestroyOnLoad (this.gameObject);
	}

	// Use this for initialization
	void Start () {
		if (enemyPrefab) {
			enemyTransform = enemyPrefab.transform;
			InvokeRepeating ("createEnemyOverTheScene",1f,2f);
		}
	}
	
	// Update is called once per frame
	void createEnemyOverTheScene () {
		if (enemyPrefab) {
			Vector3 pos = getSpawningLocation ();
			enemyObj = Instantiate (enemyPrefab.gameObject, pos ,Quaternion.identity,this.transform);
			//enemyObj.transform.position = pos;
		}
	}

	/// <summary>
	/// Gets the spawning location.
	/// </summary>
	/// <returns>The spawning location.</returns>
	Vector3 getSpawningLocation () {
		Vector3 spawnLocationForNewEnemy = Vector3.zero;
		if (spawnLocation != null) {
			int randIndex = Random.Range (0, 4);
			Debug.Log ("random index....."+randIndex);
			Transform randWall = spawnLocation[randIndex];
			if (randWall) {
				Vector3 SpawnPos = randWall.position;
				if (SpawnPos.x > 0) {//enemy at 3rd wall
					spawnLocationForNewEnemy.x = 50;
					spawnLocationForNewEnemy.y = 2;
					spawnLocationForNewEnemy.z = Random.Range (-50,50f);
				} else if (SpawnPos.x < 0) {//enemy at 4th wall
					spawnLocationForNewEnemy.x = -50;
					spawnLocationForNewEnemy.y = 2;
					spawnLocationForNewEnemy.z = Random.Range (-50,50f);
				} else if (SpawnPos.z > 0) {//enemy at 2nd wall
					spawnLocationForNewEnemy.z = 50;
					spawnLocationForNewEnemy.y = 2;
					spawnLocationForNewEnemy.x = Random.Range (-50,50f);
				} else if (SpawnPos.z < 0) {//enemy at 1st wall
					spawnLocationForNewEnemy.z = -50;
					spawnLocationForNewEnemy.y = 2;
					spawnLocationForNewEnemy.x = Random.Range (-50,50f);
				} else {
					//Debug.Log ("going for default......");
				}
				//Debug.Log ("position that occupies transform..."+randWall.position);
			}
		}
		//Debug.Log ("return location for enemy ....."+spawnLocationForNewEnemy);
		return spawnLocationForNewEnemy;
	}
}
