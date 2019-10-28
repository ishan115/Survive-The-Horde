using UnityEngine;

public class Collision_Detection : MonoBehaviour
{
    [SerializeField] GameObject[] zombiePrefabs;

    public void OnCollisionEnter(Collision other)
    {
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Rigidbody shoot = zombiePrefabs[zombieIndex].GetComponent<Rigidbody>();

        if (other.gameObject.CompareTag("Player"))
        {
            return;
        }
        else if (other.gameObject.CompareTag("Zombies"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
