using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    public float BulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire"))
        {
            Shoot();
        }
        
    }
    void Shoot(){
       GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
