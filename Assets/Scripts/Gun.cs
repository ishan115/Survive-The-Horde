using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hasHit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hasHit, range))
        {
            Debug.Log(hasHit.transform.name);

            Target_Damage target = hasHit.transform.GetComponent<Target_Damage>();

            if (target != null)
            {
                target.takeDamage(damage);
            }
        }
    }
}
