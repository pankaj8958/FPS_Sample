using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShootToKill : MonoBehaviour {

    Transform objTransform;
    Vector3 currentPos;
    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
        objTransform = this.transform;
        currentPos = objTransform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(objTransform)
        {
            this.GetComponent<Rigidbody>().velocity = this.transform.forward * 6;
        }
	}
}
