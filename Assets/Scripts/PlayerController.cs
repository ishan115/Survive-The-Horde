using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    public float speed = 20.0f;
    public float turnSpeed = 200.0f;
    public float horizontalInput;
    public float forwardInput;

    public Animator animator;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

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
    }
}