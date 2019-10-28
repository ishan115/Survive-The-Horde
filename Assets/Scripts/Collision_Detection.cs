using UnityEngine;

public class Collision_Detection : MonoBehaviour
{
    [SerializeField] GameObject[] zombiePrefabs;

    private void OnTriggerEnter(Collider other)
    {
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Rigidbody shoot = zombiePrefabs[zombieIndex].GetComponent<Rigidbody>();

        Destroy(gameObject, 5);
        Destroy(other.gameObject);
    }
}
