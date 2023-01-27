using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject BulletGen;
    public GameObject Bullet;
    public float bulletForce;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown ("f"))
        {
            GameObject bulletCopy;
            bulletCopy = Instantiate(Bullet,BulletGen.transform.position,BulletGen.transform.rotation) as GameObject;

            Rigidbody rigidCopy;
            rigidCopy = bulletCopy.GetComponent<Rigidbody>();
            rigidCopy.AddForce(-transform.right * bulletForce);
            Destroy(bulletCopy, 10.0f);
        }
        
    }
}
