using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    //Help taken from https://www.youtube.com/watch?v=7-8nE9_FwWs
    public GameObject crosshairs;
    public Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        crosshairs.transform.position = new Vector3(target.x, target.y, target.z);
    }
}
