using UnityEngine;

public class Collision_Detection : MonoBehaviour
{
    [SerializeField] GameObject zombiePrefabs;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody shoot = zombiePrefabs.GetComponent<Rigidbody>();
        FollowPlayer front = zombiePrefabs.GetComponent<FollowPlayer>();

        front.MoveSpeed = 0;

        Vector3 direction = Quaternion.Euler(0, 15, 30) * transform.forward * -10;

        shoot.AddForce(direction * 5, ForceMode.Impulse);

        Destroy(gameObject, 5);
        Destroy(other.gameObject);
    }
}
