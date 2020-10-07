using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPos = new Vector3(0, 0, 20);
    public Vector3 spawnRange = new Vector3(20,0,0);
    
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }
    
    void SpawnRandomAnimal()
    {
        GameObject selected = animalPrefabs[Mathf.RoundToInt(Random.Range(0f, animalPrefabs.Length - 1))];
        selected = Instantiate(selected, spawnPos + (spawnRange * Random.value * 2 -spawnRange), selected.transform.rotation);
        selected.transform.parent = transform;
    }
}
