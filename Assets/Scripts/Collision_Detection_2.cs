using UnityEngine;
using UnityEngine.UI;

public class Collision_Detection_2 : MonoBehaviour
{
    [SerializeField] GameObject[] zombiePrefabs;

    private void Start()
    {


    }
    public void OnCollisionEnter(Collision other)
    {
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Rigidbody shoot = zombiePrefabs[zombieIndex].GetComponent<Rigidbody>();

        ScoreUI_2 sc = GameObject.FindObjectOfType<ScoreUI_2>();

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 1);
            return;
        }
        else if (other.gameObject.CompareTag("Zombies"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            sc.increaseScore();
        }
        else
        {
            Destroy(gameObject, 3);
        }
    }
}
