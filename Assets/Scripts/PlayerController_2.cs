using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController_2 : MonoBehaviour
{
    GameObject player;

    public GameObject emptyPlayer;

    Vector3 movement;
    Vector3 mousePos;

    // Start is called before the first frame update
    public float speed = 20.0f;
    public float turnSpeed = 200.0f;
    public float horizontalInput;
    public float forwardInput;

    public float rotationSpeed;
    public float angularSpeed;

    public Animator animator;

    float score = 0f;
    public bool isOnGround = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.z);

        //Keeping the player in bound along the x axis
        if (transform.position.x < -37)
        {
            transform.position = new Vector3(-37, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 28)
        {
            transform.position = new Vector3(28, transform.position.y, transform.position.z);
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

        float midPoint = (transform.position - emptyPlayer.transform.position).magnitude;

        transform.LookAt(transform.position * midPoint);
    }
}