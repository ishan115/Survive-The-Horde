using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject[] zombiePrefabs;

    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite Heart_fill;
    public Sprite Heart_blank;

    private void Update()
    {
       
    }

    public void OnCollisionEnter(Collision other)
    {
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        Rigidbody shoot = zombiePrefabs[zombieIndex].GetComponent<Rigidbody>();

        if (other.gameObject.CompareTag("Zombies"))
        {
            health = health -1;
            healthSystem();
            Destroy(other.gameObject);

            if (health == 0)
            {
                Destroy(gameObject);

                Time.timeScale = 0f;
                SceneManager.LoadScene("GameOver");
            }
        }

    }

    public void healthSystem()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = Heart_fill;
            }
            else
            {
                hearts[i].sprite = Heart_blank;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
