using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LookAtMouse : MonoBehaviour
{
    public GameObject projectileBullet;
    [SerializeField]
    private float bulletSpeed = 40f;

    NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDir = new Vector3(Input.mousePosition.x, Input.mousePosition.y);

        Ray mouseRay = Camera.main.ScreenPointToRay(lookDir);

        float midPoint = (transform.position - Camera.main.transform.position).magnitude;
        transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);

        //Reference taken from: https://www.youtube.com/watch?v=DtT8Jnz56DY
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 Spawnpos = new Vector3(transform.position.x, -8.5f, transform.position.z);

            GameObject instBullet = Instantiate(projectileBullet, Spawnpos, Quaternion.identity) as GameObject;
            Rigidbody instRigidBullet = instBullet.GetComponent<Rigidbody>();
            instRigidBullet.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        }
    }
}
