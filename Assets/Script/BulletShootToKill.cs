using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShootToKill : MonoBehaviour {

    Transform objTransform;

    /// <summary>
    /// On hitting any target
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            if(collision.gameObject.tag.Equals("Enemy"))
            {
                Debug.Log("Hit the emeny...");
                Destroy(collision.gameObject);
            } else if(collision.gameObject.tag.Equals("Wall"))
            {
                Debug.Log("Hit the Wall ....");
            }
            Debug.Log("the collider tag...."+collision.gameObject.tag);
            Destroy(this.gameObject);
        }
    }



}
