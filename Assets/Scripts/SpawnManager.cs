using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private GameObject[] leftAnimals;
    [SerializeField] private GameObject[] rightAnimals;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 30f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeft", startDelay + 1, spawnInterval);
        InvokeRepeating("SpawnRight", startDelay + 2, spawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    private void SpawnLeft()
    {
        int index = Random.Range(0, leftAnimals.Length);
        Vector3 spawn = new Vector3(-20, 0, Random.Range(-spawnRangeX, spawnRangeX));
        Instantiate(leftAnimals[index], spawn, leftAnimals[index].transform.rotation);
    }
    private void SpawnRight()
    {
        int index = Random.Range(0, rightAnimals.Length);
        Vector3 spawn = new Vector3(20, 0, Random.Range(-spawnRangeX, spawnRangeX));
        Instantiate(rightAnimals[index], spawn, rightAnimals[index].transform.rotation);
    }
}