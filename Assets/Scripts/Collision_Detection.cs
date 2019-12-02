using UnityEngine;
using UnityEngine.UI;

public class Collision_Detection : MonoBehaviour
{
    [SerializeField] GameObject[] zombiePrefabs;

    private void Start()
    {
        
        
    }
    public void OnCollisionEnter(Collision other)
    {
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Rigidbody shoot = zombiePrefabs[zombieIndex].GetComponent<Rigidbody>();

        ScoreUI sc = GameObject.FindObjectOfType<ScoreUI>();

        if (other.gameObject.CompareTag("Player"))
        {
            return;
        }
        else if (other.gameObject.CompareTag("Zombies"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            sc.increaseScore();
        }
    }
}
