﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject Player;

    public int MoveSpeed = 15;
    int MaxDist = 10;
    int MinDist = 5;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //grab player by tag
        Player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);

        transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
}
