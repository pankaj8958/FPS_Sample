using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManShoot : MonoBehaviour
{
    public GameObject bulletRef;
    GameObject newBullet;


    void OnMouseDown()
    {
        if(bulletRef)
        {
            newBullet = Instantiate(bulletRef);
        }  
    }

}
