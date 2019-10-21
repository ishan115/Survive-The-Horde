using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Text scoreText;
    GameObject player;

    // Start is called before the first frame update
    public float speed = 20.0f;
    public float turnSpeed = 20.0f;
    public float horizontalInput;
    public float forwardInput;

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

        //moves the car forward basaed on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(transform.up * turnSpeed * horizontalInput * Time.deltaTime);
        //rotates the car based on horizontal input
    }

}