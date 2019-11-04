using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] zombiesPrefabs;

    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 31.0f;
    [SerializeField] private float startDelay = 5.0f;
    [SerializeField] private float spawnInterval = 10.0f;

    private float timer = 0f;

    private float waitTime1 = 15f;

    private float waitTime2 = 30f;

    private float waitTime3 = 60f;

    // Start is called before the first frame update
    void Start()
    {
        timer += Time.deltaTime;

        if (timer < waitTime1)
        {
            InvokeRepeating("SpawnRandomZombies", startDelay, spawnInterval);
        }
        else if (timer > waitTime1 && timer < waitTime2)
        {
            InvokeRepeating("SpawnRandomZombies", startDelay - 2f, spawnInterval - 2f);
        }
        else if (timer > waitTime2 && timer < waitTime3)
        {
            InvokeRepeating("SpawnRandomZombies", startDelay - 2f, spawnInterval - 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnRandomZombies()
    {
        if (gameObject != null)
        {
            int zombieIndex = Random.Range(0, zombiesPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), -10, spawnPosZ);

            Instantiate(zombiesPrefabs[zombieIndex], spawnPos, zombiesPrefabs[zombieIndex].transform.rotation);
        }
    }
}
