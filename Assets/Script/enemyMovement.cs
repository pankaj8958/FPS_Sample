using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

	public GameObject target;
	//Transform targetTransform;
	//public Transform startMarker;
	Transform endMarker;
	public float speed = 0.02F;
	private float startTime;
	private float journeyLength;

	// Use this for initialization
	void Start () {
		if (target) {
			endMarker = target.transform;
			startTime = Time.time;
			journeyLength = Vector3.Distance(this.transform.position, endMarker.position);
		
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target) {
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp(this.transform.position, endMarker.position, fracJourney);
		}
	}
}
