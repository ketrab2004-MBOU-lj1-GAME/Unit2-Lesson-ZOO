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
        //invoke spawn animal every spawnInterval after startDelay
    }

    /* //debug function to spawn animal on S press
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    } */
    
    void SpawnRandomAnimal()
    {
        GameObject selected = animalPrefabs[Random.Range(0, animalPrefabs.Length - 1)];
        //choose animal from prefabArray between 0 and arrayLength-1 (because array starts at 0 and ends 1 earlier)
        selected = Instantiate(selected, spawnPos + (spawnRange * Random.value * 2 -spawnRange), selected.transform.rotation);
        //change selected from prefab to copy
        //with spawn pos + range multiplied with random number (which is -.5 to .5 so *2 to make it -1 to 1) with prefab's rotation
        selected.transform.parent = transform;
        //set parent of copy so hierarchy looks cleaner
    }
}
