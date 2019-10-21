using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] zombiesPrefabs;
    public GameObject redLight;

    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 31.0f;
    [SerializeField] private float startDelay = 5.0f;
    [SerializeField] private float spawnInterval = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //randomly generate animal index and spawn location

    }

    public void SpawnRandomAnimals()
    {
        if (gameObject != null)
        {
            int animalIndex = Random.Range(0, zombiesPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), -12, spawnPosZ);

            Instantiate(zombiesPrefabs[animalIndex], spawnPos, zombiesPrefabs[animalIndex].transform.rotation);
            Instantiate(redLight, spawnPos, zombiesPrefabs[animalIndex].transform.rotation);
        }
    }
}
