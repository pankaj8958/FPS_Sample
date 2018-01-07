using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnmanager : MonoBehaviour {

	public GameObject enemyPrefab;
	public Transform playerObj;
	GameObject enemyObj = null;
	Transform enemyTransform;

	// Use this for initialization
	void Start () {
		if (enemyPrefab) {
			
			enemyTransform = enemyPrefab.transform;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (enemyPrefab) {
			enemyObj = Instantiate (enemyPrefab.gameObject, transform.position ,Quaternion.identity,this.transform);
		}
	}
}
