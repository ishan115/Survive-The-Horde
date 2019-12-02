using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LookAtMouse : MonoBehaviour
{
    public Camera EmptyPlayerCamera;
    // Start is called before the first frame update
    void Start()
    {
        EmptyPlayerCamera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame

    void Update()
    {
        Vector3 lookDir = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

        Ray mouseRay = Camera.main.ScreenPointToRay(lookDir);

        float midPoint = (transform.position - Camera.main.transform.position).magnitude;
        transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);

        //Reference taken from: https://www.youtube.com/watch?v=DtT8Jnz56DY
        
    }
}
