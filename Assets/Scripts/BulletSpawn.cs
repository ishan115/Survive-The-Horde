using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject projectileBullet;
    [SerializeField]
    private float bulletSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 Spawnpos = new Vector3(transform.position.x, -8.5f, transform.position.z);

            GameObject instBullet = Instantiate(projectileBullet, Spawnpos, Quaternion.identity) as GameObject;
            Rigidbody instRigidBullet = instBullet.GetComponent<Rigidbody>();
            instRigidBullet.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        }
    }
}
