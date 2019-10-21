using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);

        //if (Vector3.Distance(transform.position, Player.transform.position) >= MinDist)
        //{
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            //if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
            //{
            //    transform.position += transform.forward * 0 * Time.deltaTime;
            //}

        //}
    }
}
