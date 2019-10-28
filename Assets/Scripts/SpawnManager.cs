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

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomZombies", startDelay, spawnInterval);
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
