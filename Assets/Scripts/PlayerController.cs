using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    GameObject player;
    public Rigidbody rb;
    public Camera cam;

    Vector3 movement;
    Vector3 mousePos;

    // Start is called before the first frame update
    public float speed = 20.0f;
    public float bulletSpeed = 40f;
    public float turnSpeed = 200.0f;
    public float horizontalInput;
    public float forwardInput;

    public GameObject projectileBullet;

    public Animator animator;

    float score = 0f;
    public bool isOnGround = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.z);

        //Keeping the player in bound along the x axis
        if (transform.position.x < -23)
        {
            transform.position = new Vector3(-23, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 33)
        {
            transform.position = new Vector3(33, transform.position.y, transform.position.z);
        }

        //Keeping the player in bound along the z axis
        if (transform.position.z < -6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -6);
        }
        else if (transform.position.z > 51)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 51);
        }


        //moves the player forward basaed on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(transform.up * turnSpeed * horizontalInput * Time.deltaTime);
        //rotates the player based on horizontal input

        //Reference taken from: https://www.youtube.com/watch?v=DtT8Jnz56DY
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 Spawnpos = new Vector3(transform.position.x, -8.5f, transform.position.z);

            GameObject instBullet = Instantiate(projectileBullet, Spawnpos, Quaternion.identity) as GameObject;
            Rigidbody instRigidBullet = instBullet.GetComponent<Rigidbody>();
            instRigidBullet.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        }

        //mouse aiming
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    //public void FixedUpdate()
    //{
    //    Vector3 lookDir = mousePos - rb.position;
    //    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
    //    rb.rotation = angle;
    //}

}